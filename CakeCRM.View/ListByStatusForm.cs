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
    public partial class ListByStatusForm : Form
    {
        private DbSet<Sale> _sales;
        private DbSet<Pack> _packs;

        public ListByStatusForm(DbSet<SaleStatus> statuses, DbSet<Sale> sales, DbSet<Pack> packs)
        {
            InitializeComponent();
            _sales = sales;
            _packs = packs;

            saleStatusBindingSource.DataSource = statuses.Local.ToBindingList();
        }

        private void saleStatusBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            /*
             По заказу:
            1) ПИРОЖНОЕ ТОПОВОЕ С ГУСТОЙ НАЧИНКОЙ
                150 г. - 110 руб.  (Тара А)
            2) ПИРОЖНОЕ БАРХАТНОЕ
                300 г. - 240 руб  (Тара В)
            Доставка: Самовывоз (0 руб.)
           Итого: 350 руб.
            Тара: 
            Тара А - 1 шт.
            Тара В - 1 шт.
             */
            Dictionary<Pack, double> packDoubles = new Dictionary<Pack, double>();
            StringBuilder builder = new StringBuilder();
            if (!(saleStatusBindingSource.Current is SaleStatus status)) return;
            var sales = _sales.Local.Where(sl => sl.Status.Id == status.Id);
            double cost = 0;
            foreach (var sale in sales)
            {
                builder.AppendLine($"По заказу {sale.Client.Name} - {sale.Client.Communications}");
                builder.AppendLine($"\t {sale.Client.Address} - {sale.Client.Comment} ");
                int index = 1;
                foreach (var sell in sale.Goods.Sells)
                {
                    builder.AppendLine($"{index}) {sell.Variant.Product.Name} ");
                    builder.AppendLine(
                        $"{sell.Count} шт. {sell.Variant.ProductCount} гр. ({sell.Variant.Pack.Name}) \t {sell.Variant.Cost*sell.Count}");
                    index++;
                }

                builder.AppendLine($"Доставка: {sale.Delivery.Name} ({sale.Delivery.Cost} руб.)");
                builder.AppendLine($"Итого: {sale.Cost} руб.");
                cost += sale.Cost;
                builder.AppendLine("Тара:");
                foreach (var pack in _packs.Local)
                {
                    var salesByPack = sale.Goods.Sells.Where(s => s.Variant.Pack.Id == pack.Id);
                    double count = 0;
                    foreach (var pair in salesByPack)
                    {
                        count += pair.Count;
                    }

                    if (!packDoubles.ContainsKey(pack))
                    {
                        packDoubles.Add(pack,0);
                    }

                    packDoubles[pack] += count;
                    builder.AppendLine($"{pack.Name} - {Math.Round(count)}");
                }

                builder.AppendLine("___________________________");
            }

            builder.AppendLine($"\t ИТОГО: {Math.Round(cost,2)} руб.");
            builder.AppendLine($"\t Информация по таре:");
            foreach (var packDouble in packDoubles)
            {
                builder.AppendLine($"\t {packDouble.Key.Name} - {Math.Round(packDouble.Value)} шт.");
            }
            
            salesListTextBox.Text = builder.ToString();
        }
    }
}
