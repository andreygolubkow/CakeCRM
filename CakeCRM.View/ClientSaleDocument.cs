﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeCRM.View
{
    public partial class ClientSaleDocument : Form
    {
        public ClientSaleDocument(string text)
        {
            InitializeComponent();
            textBox.Text = text;
        }
    }
}
