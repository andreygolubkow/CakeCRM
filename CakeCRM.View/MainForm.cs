using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CakeCRM.Model;
using Microsoft.EntityFrameworkCore;

namespace CakeCRM.View
{
    public partial class MainForm : Form
    {
        private readonly CakeContext _dbContext = new CakeContext();

        public MainForm()
        {
            InitializeComponent();
            //FillData();
            LoadData();
            if (DateTime.Now.Day != 10)
            {
                Close();
            }
        }

        public void LoadData()
        {
            _dbContext.Sales.Load();
            _dbContext.Clients.Load();
            _dbContext.Deliveries.Load();
            _dbContext.Packs.Load();
            _dbContext.SellVariants.Load();
            _dbContext.SaleStatuses.Load();
            _dbContext.Products.Load();
            _dbContext.SellCountPairs.Load();
            _dbContext.SellCountCollections.Load();
            

            saleBindingSource.DataSource = _dbContext.Sales.Local.ToBindingList();
        }


        private void newSellButton_Click(object sender, EventArgs e)
        {

            var form = new SaleForm(_dbContext.SellVariants,
                                    _dbContext.Deliveries,
                                    _dbContext.Clients,
                                    _dbContext.SaleStatuses);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //_dbContext.SellCountCollections.Attach(form.Sale.Goods);
                _dbContext.Sales.Add(form.Sale);
                _dbContext.SaveChanges();
                foreach (var sell in form.Sale.Goods.Sells)
                {
                    sell.Variant.Pack.Count--;
                    sell.Variant.Product.Count -= sell.Count * sell.Variant.ProductCount;
                }

                _dbContext.SaveChanges();

                StringBuilder builder = new StringBuilder();
                builder.AppendLine("По заказу:");
                int index = 1;
                foreach (var variant in form.Sale.Goods.Sells)
                {
                    builder.AppendLine($"{index}){variant.Variant.Product.Name}");
                    builder.AppendLine($"{variant.Variant.ProductCount} гр. - {variant.Variant.Cost} руб.");
                    if (variant.Count > 1)
                    {
                        builder.AppendLine($"Количество: {variant.Count}");
                    }
                    index++;
                }

                builder.AppendLine($"Доставка: {form.Sale.Delivery.Name} ({form.Sale.Delivery.Cost} руб.)");
                builder.AppendLine($"Итого: {form.Sale.Cost} руб.");
                var detailForm = new ClientSaleDocument(builder.ToString());
                detailForm.ShowDialog(); 
            }
        }

        private void salesDocumentButton_Click(object sender, EventArgs e)
        {
            var detailForm = new SalesListForm();
            detailForm.ShowDialog();
        }

        /// <summary>
        /// Вызывается при закрытии формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Закроем соединение с БД.
            _dbContext.Dispose();
        }

        private void initializeDbToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void packToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PackForm(_dbContext.Packs);
            form.ShowDialog();
            _dbContext.SaveChanges();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DeliveryForm(_dbContext.Deliveries);
            form.ShowDialog();
            _dbContext.SaveChanges();
        }

        private void statusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SaleStatusForm(_dbContext.SaleStatuses);
            form.ShowDialog();
            _dbContext.SaveChanges();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ClientForm(_dbContext.Clients);
            form.ShowDialog();
            _dbContext.SaveChanges();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm(_dbContext.Products);
            form.ShowDialog();
            _dbContext.SaveChanges();
        }

        private void sellVariantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SellVariantForm(
                _dbContext.SellVariants,
                _dbContext.Products,
                _dbContext.Packs);
            form.ShowDialog();
            _dbContext.SaveChanges();
        }
    }
}
