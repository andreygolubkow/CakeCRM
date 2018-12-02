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
        private List<SellVariant> _sellVariants;

        public SaleForm(List<SellVariant> sellVariants)
        {
            _sellVariants = sellVariants;

            InitializeComponent();
            FillData();
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
