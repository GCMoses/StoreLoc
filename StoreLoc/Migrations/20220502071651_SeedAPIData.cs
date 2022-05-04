using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreLoc.Migrations
{
    public partial class SeedAPIData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "Eastern Cape", "EC" },
                    { 2, "Free State", "FS" },
                    { 3, "Gauteng", "GP" },
                    { 4, "KwaZulu-Natal", "KZN" },
                    { 5, "Limpopo", "LP" },
                    { 6, "Mpumalanga", "MP" },
                    { 7, "Northern Cape", "NC" },
                    { 8, "North West", "NW" },
                    { 9, "Western Cape", "WC" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCenters",
                columns: new[] { "Id", "Address", "Name", "OperationalHours", "PhoneNumber", "ProvinceId", "Rating" },
                values: new object[,]
                {
                    { 1, "Cnr. Baird & Gerald Smith St, Uitenhage Central, Uitenhage, 6229, Eastern Cape, South Africa", "Binnehof Centre", "Monday-Saturday 09:00AM-16:00PM, Sunday 09:00AM-13:00PM", "041 363 3621", 1, 4.5 },
                    { 8, "Nelson Mandela Dr, Potchefstroom, 2531, North West, South Africa", "MooiRivier Mall", "Monday-Saturday 09:00AM-18:00PM, Sunday 09:00AM-15:00PM", "018 293 2004", 8, 4.2999999999999998 },
                    { 7, "Cnr Oliver &, Mac Dougall St, Roads, Kimberley, 8301, Northern Cape, South Africa", "Diamond Pavilion Shopping Centre", "Monday-Thursday 09:00AM-18:00PM, Friday 09:00AM-19:00PM, Saturday 09:00AM-17:00PM, Sunday 09:00AM-18:00PM", "053 832 9200", 7, 4.2999999999999998 },
                    { 6, "X38, Corner of Bitterbessie &, Flamboyant St, West Acres, Mbombela, 1200, Mpumalanga, South Africa", "i’langa Mall", "Monday-Saturday 09:00AM-18:00PM, Sunday 09:00AM-15:00PM", "013 742 2293 or 013 742 2294", 6, 4.4000000000000004 },
                    { 9, "490 Century Blvd, Century City, Cape Town, 7446, Western Cape, South Africa", "Canal Walk", "Monday-Sunday 09:00AM-21:00PM", "021 529 9699", 9, 4.4000000000000004 },
                    { 4, "1 Palm Blvd, Umhlanga Ridge, Umhlanga, 4021, KwaZulu-Natal, South Africa", "Gateway Theatre Of Shopping", "Monday-Thursday 09:00AM-19:00PM, Friday-Saturday 09:00AM-21:00PM, Sunday 09:00AM-18:00PM", "031 514 0500", 4, 4.5 },
                    { 5, "R81, Bendor, Polokwane, 0699, Limpopo, South Africa", "Mall of the North", "Monday-Friday 09:00AM-19:00PM, Saturday-Sunday 09:00AM-17:00PM", "015 265 1026", 5, 4.5 },
                    { 3, "Eastgate Shopping Centre, 43 Bradford Rd, Bedfordview, Germiston, 2008, South Africa", "Eastgate Shopping Centre", "Monday-Sunday 09:00AM-19:00PM, Friday 09:00AM-21:00PM", "011 479 6000", 3, 4.4000000000000004 },
                    { 2, "Vereeniging Dr, Fleurdal, Bloemfontein, 9301, South Africa", "Fleurdal Mall", "Monday-Friday 08:30AM-18:00PM, Saturday 08:00AM-17:00PM, Sunday 08:00AM-14:00PM", "051 522 8141", 2, 4.2000000000000002 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Address", "Email", "Name", "OperationalHours", "PhoneNumber", "ProvinceId", "Rating", "StoreCategory", "WhatsApp" },
                values: new object[,]
                {
                    { 4, "Jet Stores, 441-453 West St, Durban Central, Durban, 4001, South Africa", "Jetinfo@edcon.co.za", "Jet Mart", "Monday-Thursday 08:30AM-17:30PM, Friday 08:00AM-18:00PM, Saturday 08:00AM-17:00PM, Sunday 09:00AM-16:00PM", "031 530 2120", 4, 4.2000000000000002, "Clothing & Retail", "N/A" },
                    { 5, "Cnr Hospital & Market St Shop 2, Game Shopping Centre, Polokwane, 1665, South Africa", "limpopo5@retail.spar.co.za", "Spar Limpopo", "Monday-Thursday 08:00AM-20:0PM, Friday 08:00AM-21:00PM, Saturday 08:00AM-20:00PM, Sunday 08:00AM-19:00PM", "015 297 4679", 5, 3.7999999999999998, "Groceries", "N/A" },
                    { 2, "Corner Eland Street, and N8 National Road Bloemfontein 9324, South Africa", "makrocare@makro.co.za", "Makro", "Monday-Friday 09:00AM-18:00PM, Saturday 08:30AM-16:00PM, Sunday 09:00AM-13:00PM", "0860 300 999", 2, 4.0999999999999996, "Wholesale(Cash & Carry)", "0860 300 999" },
                    { 6, "Shop 53, Riverside Mall, Cnr R40 White River Road & Govt Blvd, Nelspruit, Mpumalanga, 3699, South Africa", "info@forevernew.co.za", "Forever New Riverside", "Monday-Saturday 09:00AM-18:00PM, Sunday 09:00AM-15:00PM", "061 462 7818", 6, 4.4000000000000004, "Women's Clothing", "N/A" },
                    { 7, "Shop 26A, Diamond Pavillion SC, Oliver Rd, Kimberley, 8300, South Africa", "info@muggandbean.co.za", "Mugg & Bean", "Monday-Thursday 08:00AM-18:0PM, Friday 08:00AM-19:00PM, Saturday 08:00AM-17:00PM, Sunday 09:00AM-14:00PM", "053 832 0521", 7, 4.0, "Restaurant", "N/A" },
                    { 1, "	Flagstaff, Ingquza Hill, 4810, Eastern Cape, South Africa", "xtrasavings@shoprite.co.za", "Shoprite Flagstaff", "Monday-Friday 09:00AM-18:00PM, Saturday-Sunday 08:00AM-17:00PM", "039 252 7350", 1, 1.7, "Food & Retail", "087 240 5709" },
                    { 8, "Shop 6 Northwest Mall Cnr Station Carrington Main & Martin Streets Mafikeng, Mahikeng, 2745, South Africa", "customerservices@tfg.co.za", "Markham North West Mall Mafikeng", "Monday-Friday 08:00AM-17:00PM, Saturday 09:00AM-14:00PM, Sunday 09:00AM-13:00PM", "018 381 3497", 8, 4.5, "Men Clothing", "N/A" },
                    { 3, "7 Siemert Rd, Doornfontein, Johannesburg, 2094, South Africa", "bigtimebutchery@gmail.com", "Big Time Butchery & Supermarket", "Monday-Friday 06:00AM-22:00PM, Saturday-Sunday 07:00AM-22:00PM", "011 402 0177", 3, 4.2000000000000002, "Supermarket", "N/A" },
                    { 9, " Reen Ave & Carrick Road, Hatton, Cape Town, 7766, South Africa", "info@elitepowertrade.co.za", "Elite Power Trade", "Monday-Friday 07:30AM-18:00PM, Saturday 07:30AM-17:00PM, Sunday 07:30AM-13:00PM", "021 637 6810", 9, 4.2000000000000002, "Supermakret", "062 840 9367" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShoppingCenters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShoppingCenters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShoppingCenters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShoppingCenters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ShoppingCenters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ShoppingCenters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ShoppingCenters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ShoppingCenters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ShoppingCenters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
