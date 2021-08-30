using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Micro.Service.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Micro.Service.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                ImageUrl = "https://img.cavally.org/img/zhen-2019/samsa-luchshie-recepti-kak-pravilno-i-vkusno-prigotovit-camsu.jpg",
                CategoryName = "Appetizer"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Paneer Tikka",
                Price = 13.99,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                ImageUrl = "https://www.sanjanafeasts.co.uk/wp-content/uploads/2020/02/Restaurant-Style-Paneer-Tikka-recipe.jpg",
                CategoryName = "Appetizer"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 10.99,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/open-face-pear-berry-pie-e43782e.jpg?quality=90&resize=768,574",
                CategoryName = "Dessert"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pav Bhaji",
                Price = 15,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                ImageUrl = "https://static.toiimg.com/thumb/52416693.cms?imgsize=789478&width=800&height=800",
                CategoryName = "Entree"
            });
        }
    }
}
