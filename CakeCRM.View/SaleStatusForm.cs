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
    public partial class SaleStatusForm : Form
    {
        private readonly DbSet<SaleStatus> _saleStatuses;

        public SaleStatusForm(DbSet<SaleStatus> statuses)
        {
            InitializeComponent();
            _saleStatuses = statuses;
            saleStatusBindingSource.DataSource = _saleStatuses.Local.ToBindingList();
        }

        private void saleStatusBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (saleStatusBindingSource.Current is SaleStatus status)
            {
                nameTextBox.Text = status.Title;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (saleStatusBindingSource.Current != null)
            {
                saleStatusBindingSource.RemoveCurrent();
            }
        }

        private void saveAsNewButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length <= 0 ) return;
            var status = new SaleStatus()
            {
                Title = nameTextBox.Text,
            };
            saleStatusBindingSource.Add(status);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length <= 0 ) return;
            if (!(saleStatusBindingSource.Current is SaleStatus status)) return;
            status.Title = nameTextBox.Text;
            MessageBox.Show($"{status.Id}");
            saleStatusBindingSource.EndEdit();
        }
    }
}
