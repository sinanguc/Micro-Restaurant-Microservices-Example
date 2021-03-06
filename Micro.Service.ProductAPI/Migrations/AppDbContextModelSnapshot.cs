// <auto-generated />
using Micro.Service.ProductAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Micro.Service.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Micro.Service.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryName = "Appetizer",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                            ImageUrl = "https://img.cavally.org/img/zhen-2019/samsa-luchshie-recepti-kak-pravilno-i-vkusno-prigotovit-camsu.jpg",
                            Name = "Samosa",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryName = "Appetizer",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                            ImageUrl = "https://www.sanjanafeasts.co.uk/wp-content/uploads/2020/02/Restaurant-Style-Paneer-Tikka-recipe.jpg",
                            Name = "Paneer Tikka",
                            Price = 13.99
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryName = "Dessert",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                            ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/open-face-pear-berry-pie-e43782e.jpg?quality=90&resize=768,574",
                            Name = "Sweet Pie",
                            Price = 10.99
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryName = "Entree",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                            ImageUrl = "https://static.toiimg.com/thumb/52416693.cms?imgsize=789478&width=800&height=800",
                            Name = "Pav Bhaji",
                            Price = 15.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
