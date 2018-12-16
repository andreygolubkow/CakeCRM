using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            set
            {
                _sale = value;
                _sellCountPairs = _sale.Goods.Sells;
                sellCountPairBindingSource.DataSource = _sellCountPairs;
                applyButton.Visible = true;
                saveSellButton.Visible = false;
                clientBindingSource.Position = clientBindingSource.IndexOf(_sale.Client);
                deliveryBindingSource.Position = deliveryBindingSource.IndexOf(_sale.Delivery);
                saleStatusBindingSource.Position = saleStatusBindingSource.IndexOf(_sale.Status);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            double count = 0;
            if (!(double.TryParse(countTextBox.Text, out count))) return;
            if (!(sellVariantBindingSource.Current is SellVariant variant)) return;
            if (!(sellCountPairBindingSource.Current is SellCountPair pair)) return;
            var currentPacks = (_sellCountPairs.Where(p => p.Variant.Pack == variant.Pack).Sum(p => p.Count));
            var packCount = variant.Pack.Count - currentPacks;
            var productCount = variant.Product.Count - _sellCountPairs.Where(p => p.Variant.Product == variant.Product).Sum(p => p.Count * p.Variant.ProductCount);


            var pairProdCount = pair.Variant.Id == variant.Id ? pair.Variant.ProductCount * pair.Count :0;
            var pairPackCount = pair.Variant == variant ? pair.Count : 0;
            if (productCount+ pairProdCount < variant.ProductCount * count)
            {

                //MessageBox.Show($@"Недостаточно товара на складе. Доступно {Math.Round((variant.Product.Count / variant.ProductCount - variant.Product.Count) / variant.ProductCount % Math.Pow(10, 0))}");
                MessageBox.Show($@"Недостаточно товара на складе. Доступно {Math.Round(variant.Product.Count-productCount)} гр.");
                return;
            }
            if (packCount + pairPackCount < count)
            {

                MessageBox.Show($@"Недостаточно тары. Доступно: {variant.Pack.Name} - {variant.Pack.Count-packCount}");
                return;
            }

            pair.Variant = variant;
            pair.Count = count;

            sellCountPairBindingSource.EndEdit();
            sellCountPairBindingSource.ResetCurrentItem();
        }

        private void addNewPairButton_Click(object sender, EventArgs e)
        {
            double count = 0;
            if (!(double.TryParse(countTextBox.Text, out count))) return;
            if (!(sellVariantBindingSource.Current is SellVariant variant)) return;

            var packCount = variant.Pack.Count - (_sellCountPairs.Where(p => p.Variant.Pack == variant.Pack).Count() *
                        _sellCountPairs.Where(p => p.Variant.Pack == variant.Pack).Sum(p => p.Count));
            var productCount = variant.Product.Count - _sellCountPairs.Where(p => p.Variant.Product == variant.Product).Sum(p => p.Count*p.Variant.ProductCount);

            if (productCount < variant.ProductCount*count)
            {

                MessageBox.Show($@"Недостаточно товара на складе. Доступно {Math.Round(variant.Product.Count - productCount)}");
                return;
            }
            if (packCount < count)
            {

                MessageBox.Show($@"Недостаточно тары. Доступно: {variant.Pack.Name} - {variant.Pack.Count}");
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

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (!(clientBindingSource.Current is Client client)) return;
            if (!(deliveryBindingSource.Current is Delivery delivery)) return;
            if (!(saleStatusBindingSource.Current is SaleStatus status)) return;
            if (_sellCountPairs.Count <= 0) return;
            try
            {
                _sale.Client = client;
                _sale.DateTime = DateTime.Now;
                _sale.Delivery = delivery;
                _sale.Status = status;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void sellCountPairBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (sellCountPairBindingSource.Current is SellCountPair pair)
            {
                countTextBox.Text = pair.Count.ToString();
                sellVariantBindingSource.Position = sellVariantBindingSource.IndexOf(pair.Variant);
            }
        }
    }
}
