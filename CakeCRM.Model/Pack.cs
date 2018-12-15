using System;

namespace CakeCRM.Model
{
    /// <summary>
    /// Упаковка.
    /// </summary>
    public class Pack : IComparable
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество.
        /// </summary>
        public double Count { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is Pack pack)
            {
                return Id.CompareTo(pack.Id);
            }

            throw new Exception("Нельзя сравнить два объекта.");
        }
    }
}