using System;
using System.Collections.Generic;
using System.Text;

namespace CakeCRM.Model
{
    public class SellCountPairs
    {
        public int Id { get; set; }

        public Dictionary<SellVariant, double> Sells { get; } = new Dictionary<SellVariant, double>();
        
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var sell in Sells)
            {
                stringBuilder.AppendLine($"{sell.Key.Name}:{sell.Value}");
            }
            return stringBuilder.ToString();
        }
    }
}