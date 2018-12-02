using System;

namespace CakeCRM.Model
{
    /// <summary>
    /// Доставка.
    /// </summary>
    public class Delivery
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
    }
}