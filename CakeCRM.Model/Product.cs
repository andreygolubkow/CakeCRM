using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeCRM.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Count { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
