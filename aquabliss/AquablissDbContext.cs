using Microsoft.EntityFrameworkCore;

namespace aquabliss
{
    public class AquablissDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbConnection = "Server=localhost;Database=aquabliss;Uid='root';Pwd=12345";
            MySqlServerVersion mySqlServerVersion = new MySqlServerVersion(new Version(8, 10, 30));
            optionsBuilder.UseMySql(dbConnection, mySqlServerVersion);
        }

        public DbSet<User> User { get; set; }
        public DbSet<LogIn> LogIn { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Item> Item { get; set; }

    }
}
