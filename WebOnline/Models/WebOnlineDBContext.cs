using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using System.Reflection;
using WebOnline.Models.EF;

namespace WebOnline.Models
{
    public class WebOnlineDBContext : IdentityDbContext<ApplicationUser>
    {
        public WebOnlineDBContext() { }
        public WebOnlineDBContext(DbContextOptions<WebOnlineDBContext> options) : base(options) { }

        public DbSet<Ads> adv { get; set; }
        public DbSet<ApplicationUser> user { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<CartItem> cartItems { get; set; }
        public DbSet<Categorys> categorie { get; set; }
        public DbSet<Contacts> contacts { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<OderItem> oderItems { get; set; }
        public DbSet<Oders> oders { get; set; }
        public DbSet<Posts> posts { get; set; }
        public DbSet<ProductCategorys> productCategories { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<SystemSettings> systemSettings { get; set; }
        public DbSet<ProductImage> productImage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Đảm bảo gọi base method

            // Đặt tên cho các bảng Identity
            modelBuilder.Entity<ApplicationUser>(entity => 
            {
                entity.ToTable("tb_TaiKhoan"); // Tên bảng cho người dùng
            });

            modelBuilder.Entity<IdentityRole>(entity => 
            {
                entity.ToTable("tb_VaiTro"); // Tên bảng cho vai trò
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(entity => 
            {
                entity.ToTable("tb_UserClaims"); // Tên bảng cho claims của người dùng
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity => 
            {
                entity.ToTable("tb_UserLogins"); // Tên bảng cho đăng nhập của người dùng
            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity => 
            {
                entity.ToTable("tb_UserTokens"); // Tên bảng cho token của người dùng
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => 
            {
                entity.ToTable("tb_RoleClaims"); // Tên bảng cho claims của vai trò
            });

            
        }
    }
}
