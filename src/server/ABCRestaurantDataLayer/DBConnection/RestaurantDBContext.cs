using ABCRestaurant_Data.Entitys;
using Microsoft.EntityFrameworkCore;

namespace ABCRestaurant_Data.DBConnection
{
    public class RestaurantDBContext : DbContext
    {
        public RestaurantDBContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
