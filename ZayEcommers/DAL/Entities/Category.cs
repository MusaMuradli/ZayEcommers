namespace ZayEcommers.DAL.Entities
{
    public class Category : BaseEntity
    {
        public string Gender { get; set; }
        public string Sale { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
