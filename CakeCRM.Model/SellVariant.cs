﻿using System;
using CakeCRM.View;

namespace CakeCRM.Model
{
    /// <summary>
    /// Вариант продажи.
    /// </summary>
    public class SellVariant : IComparable
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public Product Product { get; set; }

        public double ProductCount { get; set; }

        public Pack Pack { get; set; }

        public double Cost { get; set; }

        public override string ToString()
        {
            return String.Format("{0}[{1}] {2}{3}", Name,Pack.Name, Cost,Configuration.Currency);
        }

        public int CompareTo(object obj)
        {
            if (obj is SellVariant variant)
            {
                return Id.CompareTo(variant.Id);
            }

            throw new Exception("Нельзя сравнить два объекта.");
        }
    }
}