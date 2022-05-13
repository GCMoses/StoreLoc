using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreLoc.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c9793da5-1e6f-466b-961f-641e25368921", "bb015dfd-f28e-4d00-b828-43c7ae5f89e0", "Administrator", "ADMINISTRATOR" },
                    { "1f831863-bad8-48bd-b182-618115ffa1f3", "7903f8c3-7c67-4fbc-97f6-96e654961cc6", "User", "USER" },
                    { "bf2920b2-f39e-4945-9240-a37be32565cd", "eb491f55-ed21-4f6e-8863-407e270a53d1", "Supervisor", "SUPERVISOR" },
                    { "1aeb70e3-4cd1-4fbf-9012-602f5d894d19", "58509f6d-500f-4a78-bcc8-fc244eb3bbd6", "Customer", "CUSTOMER" },
                    { "a0583726-0d5a-4a88-820e-01300e6654c0", "4040b753-5334-4975-9726-38aa80c8fd4e", "Employer", "EMPLOYER" }
                });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "OperationalHours" },
                values: new object[] { "consumer@shoprite.co.za", "Monday-Friday 00:00AM-18:00PM, Saturday-Sunday 08:00AM-17:00PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1aeb70e3-4cd1-4fbf-9012-602f5d894d19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f831863-bad8-48bd-b182-618115ffa1f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0583726-0d5a-4a88-820e-01300e6654c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf2920b2-f39e-4945-9240-a37be32565cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9793da5-1e6f-466b-961f-641e25368921");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "OperationalHours" },
                values: new object[] { "xtrasavings@shoprite.co.za", "Monday-Friday 09:00AM-18:00PM, Saturday-Sunday 08:00AM-17:00PM" });
        }
    }
}
