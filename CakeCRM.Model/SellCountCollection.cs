using System;
using System.Collections.Generic;
using System.Text;

namespace CakeCRM.Model
{
    public class SellCountCollection  : IComparable
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

        public int CompareTo(object obj)
        {
            if (obj is SellCountCollection collection)
            {
                return Id.CompareTo(collection.Id);
            }

            throw new Exception("Нельзя сравнить два объекта.");
        }
    }
}