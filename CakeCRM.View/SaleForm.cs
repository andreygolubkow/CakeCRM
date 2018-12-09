using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CakeCRM.Model;
using Microsoft.EntityFrameworkCore;

namespace CakeCRM.View
{
    public partial class SaleForm : Form
    {
        private Sale _sale;

        private DbSet<Client> _clients;
        private List<SellCountPair> _sellCountPairs = new List<SellCountPair>();

        public SaleForm(DbSet<SellVariant> sellVariants,
                        DbSet<Delivery> deliveries,
                        DbSet<Client> clients,
                        DbSet<SaleStatus> statuses)
        {
            InitializeComponent();
            _clients = clients;
            clientBindingSource.DataSource = _clients.Local.ToBindingList();
            deliveryBindingSource.DataSource = deliveries.Local.ToBindingList();
            sellVariantBindingSource.DataSource = sellVariants.Local.ToBindingList();
            saleStatusBindingSource.DataSource = statuses.Local.ToBindingList();
            sellCountPairBindingSource.DataSource = _sellCountPairs;

            
        }

        public Sale Sale
        {
            get { return _sale; }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            double count = 0;
            if (!(double.TryParse(countTextBox.Text, out count))) return;
            if (!(sellVariantBindingSource.Current is SellVariant variant)) return;
            if (!(sellCountPairBindingSource.Current is SellCountPair pair)) return;
            if (variant.Product.Count < variant.ProductCount * count)
            {

                MessageBox.Show($@"Недостаточно товара на складе. Доступно {Math.Round(variant.Product.Count / variant.ProductCount - variant.Product.Count / variant.ProductCount % Math.Pow(10, 0))}");
                return;
            }

            pair.Variant = variant;
            pair.Count = count;

            sellCountPairBindingSource.EndEdit();
        }

        private void addNewPairButton_Click(object sender, EventArgs e)
        {
            double count = 0;
            if (!(double.TryParse(countTextBox.Text, out count))) return;
            if (!(sellVariantBindingSource.Current is SellVariant variant)) return;
            if (variant.Product.Count < variant.ProductCount*count)
            {

                MessageBox.Show($@"Недостаточно товара на складе. Доступно {Math.Round(variant.Product.Count / variant.ProductCount - variant.Product.Count / variant.ProductCount % Math.Pow(10, 0))}");
                return;
            }

            var pair = new SellCountPair(variant,count);
            sellCountPairBindingSource.Add(pair);
        }

        private void removePairButton_Click(object sender, EventArgs e)
        {
            sellCountPairBindingSource.RemoveCurrent();
        }

        private void contactsTextBox_Leave(object sender, EventArgs e)
        {
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            var clientForm = new ClientForm(_clients);
            clientForm.ShowDialog();
        }

        private void saveSellButton_Click(object sender, EventArgs e)
        {
            if (!(clientBindingSource.Current is Client client)) return;
            if (!(deliveryBindingSource.Current is Delivery delivery)) return;
            if (!(saleStatusBindingSource.Current is SaleStatus status)) return;
            if (_sellCountPairs.Count <=0) return;
            try
            {
                _sale = new Sale();
                _sale.Client = client;
                _sale.DateTime = DateTime.Now;
                _sale.Delivery = delivery;
                _sale.Status = status;
                _sale.Goods.Sells.AddRange(_sellCountPairs);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
