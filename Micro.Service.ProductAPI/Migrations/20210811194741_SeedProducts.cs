using Microsoft.EntityFrameworkCore.Migrations;

namespace Micro.Service.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Lorem Ipsum is simply dummy text of the printing and typesetting industry", "https://img.cavally.org/img/zhen-2019/samsa-luchshie-recepti-kak-pravilno-i-vkusno-prigotovit-camsu.jpg", "Samosa", 15.0 },
                    { 2, "Appetizer", "Lorem Ipsum is simply dummy text of the printing and typesetting industry", "https://www.sanjanafeasts.co.uk/wp-content/uploads/2020/02/Restaurant-Style-Paneer-Tikka-recipe.jpg", "Paneer Tikka", 13.99 },
                    { 3, "Dessert", "Lorem Ipsum is simply dummy text of the printing and typesetting industry", "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/open-face-pear-berry-pie-e43782e.jpg?quality=90&resize=768,574", "Sweet Pie", 10.99 },
                    { 4, "Entree", "Lorem Ipsum is simply dummy text of the printing and typesetting industry", "https://static.toiimg.com/thumb/52416693.cms?imgsize=789478&width=800&height=800", "Pav Bhaji", 15.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
