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
    public partial class PackForm : Form
    {
        private readonly DbSet<Pack> _packs;

        public PackForm(DbSet<Pack> packs)
        {
            InitializeComponent();
            _packs = packs;
            packBindingSource.DataSource = packs.Local.ToBindingList();
        }

        private void packBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (packBindingSource.Current is Pack pack)
            {
                nameTextBox.Text = pack.Name;
                countTextBox.Text = pack.Count.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            double count = 0;
            if (nameTextBox.Text.Length <= 0 || !Double.TryParse(countTextBox.Text, out count)) return;
            if (!(packBindingSource.Current is Pack pack)) return;
            pack.Name = nameTextBox.Text;
            pack.Count = count;
            packBindingSource.EndEdit();
        }

        private void saveAsNewButton_Click(object sender, EventArgs e)
        {
            double count = 0;
            if (nameTextBox.Text.Length <= 0 || !Double.TryParse(countTextBox.Text, out count)) return;
            var pack = new Pack()
            {
                Name = nameTextBox.Text,
                Count = count
            };
            packBindingSource.Add(pack);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (packBindingSource.Current != null)
            {
                packBindingSource.RemoveCurrent();
            }
        }
    }
}
