namespace CakeCRM.Model
{
    public class SaleStatus
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}