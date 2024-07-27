using Ecommerce.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.API.Data
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
    }
}
