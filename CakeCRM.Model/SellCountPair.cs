namespace CakeCRM.Model
{
    public class SellCountPair
    {
        public SellCountPair()
        {
        }

        public SellCountPair(SellVariant variant, double count)
        {
            Variant = variant;
            Count = count;
        }

        public int Id { get; set; }

        public SellVariant Variant { get; set; }

        public double Count { get; set; }


    }
}