using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CakeCRM.Model;
using Microsoft.EntityFrameworkCore;

namespace CakeCRM.View
{
    public partial class ClientForm : Form
    {

        public ClientForm(DbSet<Client> clients)
        {
            InitializeComponent();
            clientBindingSource.DataSource = clients.Local.ToBindingList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (contactsTextBox.Text.Length <= 0 ) return;
            if (!(clientBindingSource.Current is Client client)) return;
            client.Address = addressTextBox.Text;
            client.Name = nameTextBox.Text;
            client.Communications = contactsTextBox.Text;
            client.Comment = commentTextBox.Text;
            clientBindingSource.EndEdit();
        }

        private void clientBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (clientBindingSource.Current is Client client)
            {
                nameTextBox.Text = client.Name;
                contactsTextBox.Text = client.Communications;
                addressTextBox.Text = client.Address;
                commentTextBox.Text = client.Comment;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (clientBindingSource.Current != null)
            {
                clientBindingSource.RemoveCurrent();
            }
        }

        private void saveAsNewButton_Click(object sender, EventArgs e)
        {
            if (contactsTextBox.Text.Length <= 0 ) return;
            var client = new Client { Name = nameTextBox.Text, Address = addressTextBox.Text, 
                Communications = contactsTextBox.Text, Comment = commentTextBox.Text};
            clientBindingSource.Add(client);
        }
    }
}
