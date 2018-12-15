using System;

namespace CakeCRM.Model
{
    /// <summary>
    /// Доставка.
    /// </summary>
    public class Delivery : IComparable
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Стоимость.
        /// </summary>
        public double Cost { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is Delivery delivery)
            {
                return Id.CompareTo(delivery.Id);
            }

            throw new Exception("Нельзя сравнить два объекта.");
        }
    }
}