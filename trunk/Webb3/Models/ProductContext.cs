using System.Data.Entity;
namespace Webb3.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("Webb3")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}