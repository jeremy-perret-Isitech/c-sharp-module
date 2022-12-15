using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarApi.Migrations
{
    public partial class addeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("02291c0e-5c88-4ab7-a7dc-e0127dbbad11"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1484d604-f82d-4487-a418-d64e10659a7a"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1b61bfd6-786d-4830-ad17-f909c0ebfc80"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("3908e7bc-06a9-4351-a696-99dfbb46b896"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("ad04993d-df4f-4c21-ab90-2e1610bb969b"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d331b226-47e8-4017-a735-9e300119a1da"));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d581da4c-aa05-454c-b2f7-7be925c158d1"),
                columns: new[] { "Brand", "Color", "FullDescription", "Model", "Price", "SmartDescription", "State", "Year" },
                values: new object[] { "Audi", "Black", "A full description with many informations", "AU-167", 12000.0, "A smart description", "New", 2017 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Color", "FullDescription", "Model", "Price", "SmartDescription", "State", "Year" },
                values: new object[,]
                {
                    { new Guid("180e526a-1b7c-4bfe-8649-6410798be28c"), "Ford", "Orange", "A full description with many informations", "FD-777", 125900.0, "A smart description", "Good condition", 2008 },
                    { new Guid("2329a453-70ac-4252-8f62-f19168479720"), "BMW", "Blue", "A full description with many informations", "BM-045", 15000.0, "A smart description", "New", 2017 },
                    { new Guid("457033c8-facd-4c77-b444-466a7b0c4d2e"), "Land Rover", "Brown", "A full description with many informations", "LR-777", 8420.0, "A smart description", "Good condition", 2015 },
                    { new Guid("a5ea99b2-bb0a-470e-b5ef-8ef12a512bdc"), "Dacia", "White", "A full description with many informations", "DC-258", 6500.0, "A smart description", "Good condition", 2011 },
                    { new Guid("b1b5fd5b-dfe9-463b-b490-726c476403ab"), "Ford", "Red", "A full description with many informations", "FD-689", 1100.0, "A smart description", "Wreck", 2012 },
                    { new Guid("df171aef-c21d-4231-ab58-202f9f4d929d"), "Opel", "Black", "A full description with many informations", "OP-001", 4000.0, "A smart description", "Good condition", 2010 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("180e526a-1b7c-4bfe-8649-6410798be28c"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2329a453-70ac-4252-8f62-f19168479720"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("457033c8-facd-4c77-b444-466a7b0c4d2e"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a5ea99b2-bb0a-470e-b5ef-8ef12a512bdc"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("b1b5fd5b-dfe9-463b-b490-726c476403ab"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("df171aef-c21d-4231-ab58-202f9f4d929d"));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d581da4c-aa05-454c-b2f7-7be925c158d1"),
                columns: new[] { "Brand", "Color", "FullDescription", "Model", "Price", "SmartDescription", "State", "Year" },
                values: new object[] { "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Color", "FullDescription", "Model", "Price", "SmartDescription", "State", "Year" },
                values: new object[,]
                {
                    { new Guid("02291c0e-5c88-4ab7-a7dc-e0127dbbad11"), "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 },
                    { new Guid("1484d604-f82d-4487-a418-d64e10659a7a"), "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 },
                    { new Guid("1b61bfd6-786d-4830-ad17-f909c0ebfc80"), "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 },
                    { new Guid("3908e7bc-06a9-4351-a696-99dfbb46b896"), "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 },
                    { new Guid("ad04993d-df4f-4c21-ab90-2e1610bb969b"), "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 },
                    { new Guid("d331b226-47e8-4017-a735-9e300119a1da"), "John", "Somewhere", "", "Iron Man", 2.02, "", "", 2008 }
                });
        }
    }
}
