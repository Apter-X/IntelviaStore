using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntelviaStore.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverPhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    CreatedByUserID = table.Column<int>(type: "int", nullable: false),
                    IncludeInCategoryID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Galery",
                columns: table => new
                {
                    PhotoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfTheProductID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galery", x => x.PhotoID);
                    table.ForeignKey(
                        name: "FK_Galery_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "CoverPhotoPath" },
                values: new object[,]
                {
                    { 1, "Book", null },
                    { 2, "Watch", null }
                });

            migrationBuilder.InsertData(
                table: "Galery",
                columns: new[] { "PhotoID", "OfTheProductID", "PhotoPath", "ProductID" },
                values: new object[,]
                {
                    { 1, 1, "images/watch01.png", null },
                    { 2, 2, "images/watch02.png", null },
                    { 3, 3, "images/book01.png", null },
                    { 4, 4, "images/book02.png", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "CreatedByUserID", "IncludeInCategoryID", "ProductDescription", "ProductName", "UnitPrice", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, 0, 1, "Peut - être le temps est - il très proche où l'on s'avisera que la pierre angulaire des édifices sublimes et inconditionnés que les philosophes dogmatiques", "Par-delà bien et mal", 8.5999999999999996, new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, 0, 1, "Alain Soral dérange, agace, mais il l'un des rares penseurs de sa génération à se poser et à poser les bonnes questions : celles qui font mal, parfois, et surtout celle que l'on n'aime pas s'entendre poser.", "Comprendre l'Empire", 15.5, new DateTime(2011, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, 0, 2, "Sivis pasem para belum.", "Festina Chronograph", 79.989999999999995, new DateTime(2019, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, 0, 2, "Lorem Ipsum Mostrious Giligitamous.", "Swatch Originals Big Bold Jellyfish", 189.99000000000001, new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Galery_ProductID",
                table: "Galery",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galery");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
