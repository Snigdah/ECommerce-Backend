using ECommerce_API.Model;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User>Users { get; set; }
    }
}
