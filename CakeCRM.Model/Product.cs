using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeCRM.Model
{
    public class Product : IComparable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Count { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is Product product)
            {
                return Id.CompareTo(product.Id);
            }

            throw new Exception("Нельзя сравнить два объекта.");
        }

    }
}
