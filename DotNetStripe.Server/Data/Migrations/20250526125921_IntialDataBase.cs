using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetStripe.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class IntialDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { "25a8358b-36b3-48e2-8301-127ac0806e30", "Description of product 0, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/0/500", 1000m, "Product 0" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e31", "Description of product 1, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/1/500", 1001m, "Product 1" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e310", "Description of product 10, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/10/500", 1010m, "Product 10" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e311", "Description of product 11, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/11/500", 1011m, "Product 11" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e312", "Description of product 12, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/12/500", 1012m, "Product 12" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e313", "Description of product 13, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/13/500", 1013m, "Product 13" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e314", "Description of product 14, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/14/500", 1014m, "Product 14" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e315", "Description of product 15, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/15/500", 1015m, "Product 15" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e316", "Description of product 16, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/16/500", 1016m, "Product 16" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e317", "Description of product 17, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/17/500", 1017m, "Product 17" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e318", "Description of product 18, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/18/500", 1018m, "Product 18" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e319", "Description of product 19, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/19/500", 1019m, "Product 19" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e32", "Description of product 2, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/2/500", 1002m, "Product 2" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e33", "Description of product 3, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/3/500", 1003m, "Product 3" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e34", "Description of product 4, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/4/500", 1004m, "Product 4" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e35", "Description of product 5, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/5/500", 1005m, "Product 5" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e36", "Description of product 6, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/6/500", 1006m, "Product 6" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e37", "Description of product 7, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/7/500", 1007m, "Product 7" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e38", "Description of product 8, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/8/500", 1008m, "Product 8" },
                    { "25a8358b-36b3-48e2-8301-127ac0806e39", "Description of product 9, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/9/500", 1009m, "Product 9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
