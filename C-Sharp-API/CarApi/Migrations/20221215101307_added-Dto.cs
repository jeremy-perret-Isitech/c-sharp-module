using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarApi.Migrations
{
    public partial class addedDto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("27bc80ab-2f07-4a6e-941d-58f6585c5723"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2969ca26-53ee-43a5-b4d7-76f45b971d56"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("55ba7c75-765d-4881-bf55-605adcb500a3"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("658fcc45-373b-400d-8858-304c24f091ff"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("82c0294b-ddf8-4791-a121-f3d81f7af9c9"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("b6a63561-5328-4211-81d6-41195057983e"));

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cars",
                newName: "State");

            migrationBuilder.AddColumn<string>(
                name: "FullDescription",
                table: "Cars",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "SmartDescription",
                table: "Cars",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d581da4c-aa05-454c-b2f7-7be925c158d1"),
                columns: new[] { "FullDescription", "SmartDescription" },
                values: new object[] { "", "" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Color", "FullDescription", "Model", "Price", "SmartDescription", "State", "Year" },
                values: new object[,]
                {
                    { new Guid("47a17e97-c52f-4cc5-81c8-361149e0bf06"), "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 },
                    { new Guid("89c672e3-7e41-4efd-86e5-7a65a25d5b2e"), "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 },
                    { new Guid("a09e9c2a-30a4-4eae-8ecd-d6cc9a4926e2"), "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 },
                    { new Guid("c6ae4fc6-aa53-42c5-860c-377860b8ed22"), "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 },
                    { new Guid("cfc7d438-8d3c-4a05-99db-b86c8976821a"), "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 },
                    { new Guid("f2e6b04b-32ee-4665-a4ef-23d7d06aa2b9"), "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("47a17e97-c52f-4cc5-81c8-361149e0bf06"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("89c672e3-7e41-4efd-86e5-7a65a25d5b2e"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a09e9c2a-30a4-4eae-8ecd-d6cc9a4926e2"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("c6ae4fc6-aa53-42c5-860c-377860b8ed22"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("cfc7d438-8d3c-4a05-99db-b86c8976821a"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("f2e6b04b-32ee-4665-a4ef-23d7d06aa2b9"));

            migrationBuilder.DropColumn(
                name: "FullDescription",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SmartDescription",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Cars",
                newName: "Description");

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
                    { new Guid("b6a63561-5328-4211-81d6-41195057983e"), "John", "Somewhere", "", "Iron Man", 2.02, 2008 }
                });
        }
    }
}
