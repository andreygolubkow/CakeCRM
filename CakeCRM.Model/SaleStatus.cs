using System;

namespace CakeCRM.Model
{
    public class SaleStatus : IComparable
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }

        public int CompareTo(object obj)
        {
            if (obj is SaleStatus status)
            {
                return Id.CompareTo(status.Id);
            }

            throw new Exception("Нельзя сравнить два объекта.");
        }
    }
}