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

        private StringBuilder _balanceMessage = new StringBuilder();

        private const double _minPack = 20;
        private const double _minProduct = 100;

        public MainForm()
        {
            InitializeComponent();
            //FillData();
            LoadData();
            if (DateTime.Now.Day != 16)
            {
                Close();
            }

            CheckBalance();
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


            saleStatusBindingSource.DataSource = _dbContext.SaleStatuses.Local.ToBindingList();
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
            saleBindingSource.ResetBindings(false);
            CheckBalance();
        }

        private void salesDocumentButton_Click(object sender, EventArgs e)
        {
            var form = new ListByStatusForm(_dbContext.SaleStatuses,_dbContext.Sales,_dbContext.Packs);
            form.ShowDialog();
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
            CheckBalance();
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
            CheckBalance();
        }

        private void sellVariantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SellVariantForm(
                _dbContext.SellVariants,
                _dbContext.Products,
                _dbContext.Packs);
            form.ShowDialog();
            _dbContext.SaveChanges();
            CheckBalance();
        }

        private void removeSaleButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("При удалении, товары и тара будут возвращены.","Удаление заказа",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (saleBindingSource.Current is Sale sale)
                {
                    foreach (var sell in sale.Goods.Sells)
                    {
                        //Вернем тару
                        sell.Variant.Pack.Count += sell.Count;
                       //Вернем товар
                        sell.Variant.Product.Count += sell.Variant.ProductCount * sell.Count;
                    }
                    saleBindingSource.RemoveCurrent();
                    _dbContext.SaveChanges();
                    CheckBalance();
                }
            }
        }

        private void changeStatusButton_Click(object sender, EventArgs e)
        {
            
        }

        private void statusComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            saleBindingSource.EndEdit();
            _dbContext.SaveChanges();
        }

        private void showClientInfoButton_Click(object sender, EventArgs e)
        {
            if (!(saleBindingSource.Current is Sale sale)) return;

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("По заказу:");
            int index = 1;
            foreach (var variant in sale.Goods.Sells)
            {
                builder.AppendLine($"{index}){variant.Variant.Product.Name}");
                builder.AppendLine($"{variant.Variant.ProductCount} гр. - {variant.Variant.Cost} руб.");
                if (variant.Count > 1)
                {
                    builder.AppendLine($"Количество: {variant.Count}");
                }
                index++;
            }

            builder.AppendLine($"Доставка: {sale.Delivery.Name} ({sale.Delivery.Cost} руб.)");
            builder.AppendLine($"Итого: {sale.Cost} руб.");
            var detailForm = new ClientSaleDocument(builder.ToString());
            detailForm.ShowDialog();
        }

        private void CheckBalance()
        {
            var str = "Заканчиваются:";
            _balanceMessage = new StringBuilder();
            _balanceMessage.AppendLine("Заканчиваются:");
            foreach (var pack in _dbContext.Packs)
            {
                if (pack.Count < _minPack)
                {
                    str += $" {pack.Name}";
                    _balanceMessage.AppendLine($"{pack.Name} - {pack.Count} шт.");
                }
            }

            foreach (var product in _dbContext.Products)
            {
                if (product.Count < _minProduct)
                {
                    str+= $" {product.Name}";
                    _balanceMessage.AppendLine($"{product.Name} - {product.Count} гр.");
                }
            }

            balanceText.Text = str;
        }

        private void balanceText_DoubleClick(object sender, EventArgs e)
        {
            var cost = _dbContext.Sales.ToList().Where(s => s.DateTime.Date.Equals(DateTime.Now.Date)).Sum(s=>s.Cost);
            _balanceMessage.AppendLine($"Сегодня продано на {Math.Round(cost,2)} руб.");
            MessageBox.Show(_balanceMessage.ToString(),"Баланс");
            CheckBalance();
        }

        private void editSaleButton_Click(object sender, EventArgs e)
        {
            if (saleBindingSource.Current is Sale sale)
            {
                var form = new SaleForm(_dbContext.SellVariants,
                    _dbContext.Deliveries,
                    _dbContext.Clients,
                    _dbContext.SaleStatuses);

                //Вернем средства
                foreach (var sell in sale.Goods.Sells)
                {
                    //Вернем тару
                    sell.Variant.Pack.Count += sell.Count;
                    //Вернем товар
                    sell.Variant.Product.Count += sell.Variant.ProductCount * sell.Count;
                }
                _dbContext.SaveChanges();
                

                form.Sale = sale;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //_dbContext.SellCountCollections.Attach(form.Sale.Goods);
                    _dbContext.SaveChanges();
                    //Вычтем средсва
                    foreach (var sell in form.Sale.Goods.Sells)
                    {
                        sell.Variant.Pack.Count -= sell.Count;
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
                else
                {
                    _dbContext.UndoChanges();
                    LoadData();
                    //Вычтем средсва
                    foreach (var sell in form.Sale.Goods.Sells)
                    {
                        sell.Variant.Pack.Count -= sell.Count;
                        sell.Variant.Product.Count -= sell.Count * sell.Variant.ProductCount;
                    }

                    _dbContext.SaveChanges();
                }
                
                CheckBalance();
                saleBindingSource.ResetBindings(false);
            }
        }

        private void copyClientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(saleBindingSource.Current is Sale sale)) return;

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("По заказу:");
            int index = 1;
            foreach (var variant in sale.Goods.Sells)
            {
                builder.AppendLine($"{index}){variant.Variant.Product.Name}");
                builder.AppendLine($"{variant.Variant.ProductCount} гр. - {variant.Variant.Cost} руб.");
                if (variant.Count > 1)
                {
                    builder.AppendLine($"Количество: {variant.Count}");
                }
                index++;
            }

            builder.AppendLine($"Доставка: {sale.Delivery.Name} ({sale.Delivery.Cost} руб.)");
            builder.AppendLine($"Итого: {sale.Cost} руб.");
            
            Clipboard.SetText(builder.ToString());
        }

        private void salesGridView_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void salesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (saleBindingSource.Current is Sale sale)
            {
                sellContextMenu.Show(MousePosition.X,MousePosition.Y);
            }
        }
    }
}
