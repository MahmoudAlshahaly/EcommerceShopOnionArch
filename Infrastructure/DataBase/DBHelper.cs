using DataAccessLayer.Infrastructure.ConFigration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedLayer.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infrastructure.DataBase
{
    public class DBHelper: IdentityDbContext<ApplicationUser>
    {
        public DBHelper(DbContextOptions<DBHelper> options) :base(options)
        {
                
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("write here connection string");
        //    base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            //this filter fire automtic cross any query which get data from database
            //that apply for any query in this entity i select it
            //modelBuilder.Entity<Product>().HasQueryFilter(p => !p.isdeleted);

            //ican ignore query filter for specific query 
            //var b = db.product.IgnoreQueryFilters().ToList();


            modelBuilder.Entity<IdentityRole>().HasData(
                       new { Id = "f2c3f0d1-77e5-4fc2-bb59-b6b811380be7", Name = "Admin" },
                       new { Id = "f2c3f0d1-77e5-4fc2-bb59-b6b811380be6", Name = "User" });

            ApplicationUser user = new ApplicationUser()
            {
                FullName = "Admin",
                Email = "ayaahmed199910@gmail.com",
                Address = "cairo",
                BirthDate = "1999-10-29",
                Gender = "Female",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "AYAAHMED199910@GMAIL.COM",
                EmailConfirmed = true
            };
            var password = "Admin1234#";
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            var hashedPassword = passwordHasher.HashPassword(user, password);
            user.PasswordHash = hashedPassword;
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<IdentityUserRole<string>>()
                     .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = user.Id, RoleId = "f2c3f0d1-77e5-4fc2-bb59-b6b811380be7" });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ComplaintAndSuggestion> ComplaintAndSuggestions { get; set; }
        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
