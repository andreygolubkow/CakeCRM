using System;
using System.Collections.Generic;
using System.Text;

namespace CakeCRM.Model
{
    public class SellCountCollection
    {
        public int Id { get; set; }

        public List<SellCountPair> Sells { get; } = new List<SellCountPair>();
        
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var sell in Sells)
            {
                stringBuilder.AppendLine($"{sell.Variant.Name}:{sell.Count}");
            }
            return stringBuilder.ToString();
        }
    }
}