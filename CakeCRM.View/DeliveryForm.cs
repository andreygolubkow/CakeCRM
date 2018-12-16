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
    public partial class DeliveryForm : Form
    {
        public DeliveryForm(DbSet<Delivery> deliveries)
        {
            InitializeComponent();
            deliveryBindingSource.DataSource = deliveries.Local.ToBindingList();
        }

        private void deliveryBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (deliveryBindingSource.Current is Delivery delivery)
            {
                nameTextBox.Text = delivery.Name;
                costTextBox.Text = delivery.Cost.ToString();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (deliveryBindingSource.Current != null)
            {
                deliveryBindingSource.RemoveCurrent();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            double cost = 0;
            if (nameTextBox.Text.Length <= 0 || !Double.TryParse(costTextBox.Text, out cost)) return;
            if (!(deliveryBindingSource.Current is Delivery delivery)) return;
            delivery.Name = nameTextBox.Text;
            delivery.Cost = cost;
            deliveryBindingSource.EndEdit();
            deliveryBindingSource.ResetCurrentItem();
        }

        private void saveAsNewButton_Click(object sender, EventArgs e)
        {
            double cost = 0;
            if (nameTextBox.Text.Length <= 0 || !Double.TryParse(costTextBox.Text, out cost)) return;
            var delivery = new Delivery {Name = nameTextBox.Text, Cost = cost};
            deliveryBindingSource.Add(delivery);
        }
    }
}
