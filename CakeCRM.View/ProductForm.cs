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
    public partial class ProductForm : Form
    {
        public ProductForm(DbSet<Product> products)
        {
            InitializeComponent();
            productBindingSource.DataSource = products.Local.ToBindingList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (productBindingSource.Current != null)
            {
                productBindingSource.RemoveCurrent();
            }
        }

        private void saveAsNewButton_Click(object sender, EventArgs e)
        {
            double count = 0;
            if (nameTextBox.Text.Length <=0 || !Double.TryParse(countTextBox.Text,out count)) return;
            var product = new Product()
            {
                Name = nameTextBox.Text,
                Count = count
            };
            productBindingSource.Add(product);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            double count = 0;
            if (nameTextBox.Text.Length <= 0 || !double.TryParse(countTextBox.Text, out count)) return;
            if (!(productBindingSource.Current is Product product)) return;
            product.Name = nameTextBox.Text;
            product.Count = count;
            productBindingSource.EndEdit();
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (productBindingSource.Current == null) return;
            if (!(productBindingSource.Current is Product product)) return;
            nameTextBox.Text = product.Name;
            countTextBox.Text = product.Count.ToString();
        }
    }
}
