using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarApi.Migrations
{
    public partial class addedDtog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
