using System;
using System.Collections.Generic;

namespace CakeCRM.Model
{
    public class Sale
    {
        public int Id { get; set; }
        
        public Client Client { get; set; }

        /// <summary>
        /// Позиция-количество.
        /// </summary>
        public SellCountCollection Goods { get; } = new SellCountCollection();

        public Delivery Delivery { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;

        public double Cost
        {
            get
            {
                double cost = 0;
                foreach (var position in Goods.Sells)
                {
                    cost += position.Variant.Cost * position.Count;
                }

                if (Delivery != null)
                {
                    cost += Delivery.Cost;
                }

                return cost;
            }
        }
    }
}