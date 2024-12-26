namespace HW_18.Domain.Entites
{
    public class Category
    {
        #region Propetice
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion


        #region NavigatuionPropertice
        public List<Product> Products { get; set; } = new List<Product>();
        #endregion
    }
}
