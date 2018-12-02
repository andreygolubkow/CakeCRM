namespace CakeCRM.Model
{
    /// <summary>
    /// Упаковка.
    /// </summary>
    public class Pack
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public string Id { get; set; }

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
    }
}