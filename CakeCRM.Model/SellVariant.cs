using System;

namespace CakeCRM.Model
{
    /// <summary>
    /// Вариант продажи.
    /// </summary>
    public class SellVariant
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public Product Product { get; set; }

        public double ProductCount { get; set; }

        public Pack Pack { get; set; }

        public double Cost { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", Name, Cost);
        }
    }
}