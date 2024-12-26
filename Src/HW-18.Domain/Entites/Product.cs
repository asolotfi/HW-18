namespace HW_18.Domain.Entites
{
    public class Product
    {
        #region Propetice
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
