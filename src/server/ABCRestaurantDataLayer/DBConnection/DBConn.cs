using ABCRestaurantDataLayer.Entitys;
using Microsoft.EntityFrameworkCore;


namespace ABCRestaurantDataLayer.DBConnection
{
    public class DBConn : DbContext
    {
        public DBConn(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
