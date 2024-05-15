using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebOnline.Models.EF;

namespace WebOnline.Models
{
    public class WebOnlineDBContext : DbContext
    {
        public WebOnlineDBContext() { }
        public WebOnlineDBContext(DbContextOptions<WebOnlineDBContext> options) : base(options) { }

        public DbSet<Ads> adv { get; set; }
        public DbSet<Categorys> categorie { get; set; }
        public DbSet<Contacts> contacts { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<OderDetails> oderDetails { get; set; }
        public DbSet<Oders> oders { get; set; }
        public DbSet<Posts> posts { get; set; }
        public DbSet<ProductCategorys> productCategories { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<SystemSettings> systemSettings { get; set; }
        public DbSet<ProductImage> productImage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
