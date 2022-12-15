using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarApi.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Model = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brand = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Color", "Description", "Model", "Price", "Year" },
                values: new object[,]
                {
                    { new Guid("27bc80ab-2f07-4a6e-941d-58f6585c5723"), "John", "Somewhere", "", "Iron Man", 2.02, 2008 },
                    { new Guid("2969ca26-53ee-43a5-b4d7-76f45b971d56"), "John", "Somewhere", "", "Iron Man", 2.02, 2008 },
                    { new Guid("55ba7c75-765d-4881-bf55-605adcb500a3"), "John", "Somewhere", "", "Iron Man", 2.02, 2008 },
                    { new Guid("658fcc45-373b-400d-8858-304c24f091ff"), "John", "Somewhere", "", "Iron Man", 2.02, 2008 },
                    { new Guid("82c0294b-ddf8-4791-a121-f3d81f7af9c9"), "John", "Somewhere", "", "Iron Man", 2.02, 2008 },
                    { new Guid("b6a63561-5328-4211-81d6-41195057983e"), "John", "Somewhere", "", "Iron Man", 2.02, 2008 },
                    { new Guid("d581da4c-aa05-454c-b2f7-7be925c158d1"), "John", "Somewhere", "", "Iron Man", 2.02, 2008 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
