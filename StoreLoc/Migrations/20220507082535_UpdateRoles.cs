using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreLoc.Migrations
{
    public partial class UpdateRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b8631a9-ea16-4b63-a568-0584cd1fc9b9", "64d02fe4-a300-4abe-a4b4-59d540304a10", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a300cc7c-73dc-496b-b99a-a35c7aff9184", "8c45316c-5197-4e4f-9350-8364a88a558f", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b8631a9-ea16-4b63-a568-0584cd1fc9b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a300cc7c-73dc-496b-b99a-a35c7aff9184");

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
        }
    }
}
