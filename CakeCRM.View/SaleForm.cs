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

namespace CakeCRM.View
{
    public partial class SaleForm : Form
    {
        private readonly BindingList<SellVariant> _sellVariants;
        private readonly BindingList<Delivery> _deliveries;
        private readonly BindingList<Client> _clients;

        public SaleForm(BindingList<SellVariant> sellVariants,
                        BindingList<Delivery> deliveries,
                        BindingList<Client> clients)
        {
            _sellVariants = sellVariants;
            _deliveries = deliveries;
            _clients = clients;

            InitializeComponent();
        }

        public void ConnectSellVariants()
        {

        }

        public void FillData()
        {
            var pairs = new List<SellCountPair>();
            var pair = new SellCountPair(_sellVariants.First(),2);
            pairs.Add(pair);
            sellCountPairBindingSource.DataSource = pairs;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
