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
    public partial class SellVariantForm : Form
    {
        public SellVariantForm(
            DbSet<SellVariant> sellVariants,
            DbSet<Product> products,
            DbSet<Pack> packs)
        {
            InitializeComponent();
            productBindingSource.DataSource = products.Local.ToBindingList();
            packBindingSource.DataSource = packs.Local.ToBindingList();
            sellVariantBindingSource.DataSource = sellVariants.Local.ToBindingList();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            sellVariantBindingSource.AddNew();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            sellVariantBindingSource.EndEdit();
            sellVariantBindingSource.ResetCurrentItem();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            sellVariantBindingSource.RemoveCurrent();
        }
    }
}
