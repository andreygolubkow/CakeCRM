﻿using System;
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
    public partial class MainForm : Form
    {
        private List<Client> _clients = new List<Client>();
        private List<Delivery> _deliveries = new List<Delivery>();
        private List<Pack> _packs = new List<Pack>();
        private List<Product> _products = new List<Product>();
        private List<Sale> _sales = new List<Sale>();
        private List<SellVariant> _sellVariants = new List<SellVariant>();


        public MainForm()
        {
            InitializeComponent();
            FillData();
            saleBindingSource.DataSource = _sales;
        }

        private void FillData()
        {
            var client = new Client();
            client.Address = "Иванова 10";
            client.Name = "Аркадий";
            client.PhoneNumber = "+7 998 965 67 55";
            _clients.Add(client);

            var delivery = new Delivery();
            delivery.Name = "Самовывоз";
            delivery.Cost = 0;
            _deliveries.Add(delivery);

            var pack = new Pack();
            pack.Name = "Тара А";
            pack.Count = 15;
            _packs.Add(pack);

            var product = new Product();
            product.Count = 1500;
            product.Name = "ПИРОЖНОЕ БАРХАТНОЕ";
            _products.Add(product);

            var sellVariant1 = new SellVariant();
            sellVariant1.Pack = pack;
            sellVariant1.Cost = 1200;
            sellVariant1.Name = "ПИРОЖНОЕ БАРХАТНОЕ 150 гр.";
            sellVariant1.Product = product;
            sellVariant1.ProductCount = 150;
            _sellVariants.Add(sellVariant1);

            var sellVariant2 = new SellVariant();
            sellVariant2.Pack = pack;
            sellVariant2.Cost = 1500;
            sellVariant2.Name = "ПИРОЖНОЕ БАРХАТНОЕ 300 гр.";
            sellVariant2.Product = product;
            sellVariant2.ProductCount = 300;
            _sellVariants.Add(sellVariant2);

            var sale1 = new Sale();
            sale1.Delivery = delivery;
            sale1.Client = client;
            sale1.DateTime = DateTime.Now;
            sale1.Goods.Sells.Add(sellVariant1,2);
            sale1.Goods.Sells.Add(sellVariant2,1);
            _sales.Add(sale1);

            var sale2 = new Sale();
            sale2.Delivery = delivery;
            sale2.Client = client;
            sale2.DateTime = DateTime.Now.AddDays(-1);
            sale2.Goods.Sells.Add(sellVariant2, 2);
            _sales.Add(sale2);
        }
    }
}