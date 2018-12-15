using System;

namespace CakeCRM.Model
{
    /// <summary>
    /// Клиент.
    /// </summary>
    public class Client : IComparable
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Контакты.
        /// </summary>
        public string Communications { get; set; }

        /// <summary>
        /// Адрес.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Комментарий.
        /// </summary>
        public string Comment { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}->{2}",Name,Communications,Address);
        }

        public int CompareTo(object obj)
        {
            if (obj is Client client)
            {
                return String.Compare(ToString(), client.ToString(), StringComparison.CurrentCulture);
            }

            throw new Exception("Нельзя сравнить два объекта.");
        }
    }
}