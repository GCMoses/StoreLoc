using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreLoc.APIData
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Province>().HasData(
                new Province
                {
                    Id = 1,
                    Name = "Eastern Cape",
                    ShortName = "EC"
                },
                new Province
                {
                    Id = 2,
                    Name = "Free State",
                    ShortName = "FS"
                },
                new Province
                {
                    Id = 3,
                    Name = "Gauteng",
                    ShortName = "GP"
                },
                new Province
                {
                    Id = 4,
                    Name = "KwaZulu-Natal",
                    ShortName = "KZN"
                },
                new Province
                {
                    Id = 5,
                    Name = "Limpopo",
                    ShortName = "LP"
                },
                new Province
                {
                    Id = 6,
                    Name = "Mpumalanga",
                    ShortName = "MP"
                },
                new Province
                {
                    Id = 7,
                    Name = "Northern Cape",
                    ShortName = "NC"
                },
                new Province
                {
                    Id = 8,
                    Name = "North West",
                    ShortName = "NW"
                },
                new Province
                {
                    Id = 9,
                    Name = "Western Cape",
                    ShortName = "WC"
                }
            );

            builder.Entity<ShoppingCenter>().HasData(
                new ShoppingCenter
                {
                    Id = 1,
                    Name = "Binnehof Centre",
                    Address = "Cnr. Baird & Gerald Smith St, Uitenhage Central, Uitenhage, 6229, Eastern Cape, South Africa",
                    PhoneNumber = "041 363 3621",
                    Rating = 4.5,
                    OperationalHours = "Monday-Saturday 09:00AM-16:00PM, Sunday 09:00AM-13:00PM",
                    ProvinceId = 1
                },
                new ShoppingCenter
                {
                    Id = 2,
                    Name = "Fleurdal Mall",
                    Address = "Vereeniging Dr, Fleurdal, Bloemfontein, 9301, South Africa",
                    PhoneNumber = "051 522 8141",
                    Rating = 4.2,
                    OperationalHours = "Monday-Friday 08:30AM-18:00PM, Saturday 08:00AM-17:00PM, Sunday 08:00AM-14:00PM",
                    ProvinceId = 2
                },
                new ShoppingCenter
                {
                    Id = 3,
                    Name = "Eastgate Shopping Centre",
                    Address = "Eastgate Shopping Centre, 43 Bradford Rd, Bedfordview, Germiston, 2008, South Africa",
                    PhoneNumber = "011 479 6000",
                    Rating = 4.4,
                    OperationalHours = "Monday-Sunday 09:00AM-19:00PM, Friday 09:00AM-21:00PM",
                    ProvinceId = 3
                },
                 new ShoppingCenter
                 {
                     Id = 4,
                     Name = "Gateway Theatre Of Shopping",
                     Address = "1 Palm Blvd, Umhlanga Ridge, Umhlanga, 4021, KwaZulu-Natal, South Africa",
                     PhoneNumber = "031 514 0500",
                     Rating = 4.5,
                     OperationalHours = "Monday-Thursday 09:00AM-19:00PM, Friday-Saturday 09:00AM-21:00PM, Sunday 09:00AM-18:00PM",
                     ProvinceId = 4
                 },
                new ShoppingCenter
                {
                    Id = 5,
                    Name = "Mall of the North",
                    Address = "R81, Bendor, Polokwane, 0699, Limpopo, South Africa",
                    PhoneNumber = "015 265 1026",
                    Rating = 4.5,
                    OperationalHours = "Monday-Friday 09:00AM-19:00PM, Saturday-Sunday 09:00AM-17:00PM",
                    ProvinceId = 5
                },
                new ShoppingCenter
                {
                    Id = 6,
                    Name = "i’langa Mall",
                    Address = "X38, Corner of Bitterbessie &, Flamboyant St, West Acres, Mbombela, 1200, Mpumalanga, South Africa",
                    PhoneNumber = "013 742 2293 or 013 742 2294",
                    Rating = 4.4,
                    OperationalHours = "Monday-Saturday 09:00AM-18:00PM, Sunday 09:00AM-15:00PM",
                    ProvinceId = 6
                },
                 new ShoppingCenter
                 {
                     Id = 7,
                     Name = "Diamond Pavilion Shopping Centre",
                     Address = "Cnr Oliver &, Mac Dougall St, Roads, Kimberley, 8301, Northern Cape, South Africa",
                     PhoneNumber = "053 832 9200",
                     Rating = 4.3,
                     OperationalHours = "Monday-Thursday 09:00AM-18:00PM, Friday 09:00AM-19:00PM, Saturday 09:00AM-17:00PM, Sunday 09:00AM-18:00PM",
                     ProvinceId = 7
                 },
                new ShoppingCenter
                {
                    Id = 8,
                    Name = "MooiRivier Mall",
                    Address = "Nelson Mandela Dr, Potchefstroom, 2531, North West, South Africa",
                    PhoneNumber = "018 293 2004",
                    Rating = 4.3,
                    OperationalHours = "Monday-Saturday 09:00AM-18:00PM, Sunday 09:00AM-15:00PM",
                    ProvinceId = 8
                },
                new ShoppingCenter
                {
                    Id = 9,
                    Name = "Canal Walk",
                    Address = "490 Century Blvd, Century City, Cape Town, 7446, Western Cape, South Africa",
                    PhoneNumber = "021 529 9699",
                    Rating = 4.4,
                    OperationalHours = "Monday-Sunday 09:00AM-21:00PM",
                    ProvinceId = 9
                }
            );

            builder.Entity<Store>().HasData(
                new Store
                {
                    Id = 1,
                    Name = "Shoprite Flagstaff",
                    Address = "	Flagstaff, Ingquza Hill, 4810, Eastern Cape, South Africa",
                    PhoneNumber = "039 252 7350",
                    WhatsApp = "087 240 5709",
                    Email = "xtrasavings@shoprite.co.za",
                    Rating = 1.7,
                    StoreCategory = "Food & Retail",
                    OperationalHours = "Monday-Friday 09:00AM-18:00PM, Saturday-Sunday 08:00AM-17:00PM",
                    ProvinceId = 1
                },

                new Store
                {
                    Id = 2,
                    Name = "Makro",
                    Address = "Corner Eland Street, and N8 National Road Bloemfontein 9324, South Africa",
                    PhoneNumber = "0860 300 999",
                    WhatsApp = "0860 300 999",
                    Email = "makrocare@makro.co.za",
                    Rating = 4.1,
                    StoreCategory = "Wholesale(Cash & Carry)",
                    OperationalHours = "Monday-Friday 09:00AM-18:00PM, Saturday 08:30AM-16:00PM, Sunday 09:00AM-13:00PM",
                    ProvinceId = 2
                },
                  new Store
                  {
                      Id = 3,
                      Name = "Big Time Butchery & Supermarket",
                      Address = "7 Siemert Rd, Doornfontein, Johannesburg, 2094, South Africa",
                      PhoneNumber = "011 402 0177",
                      WhatsApp = "N/A",
                      Email = "bigtimebutchery@gmail.com",
                      Rating = 4.2,
                      StoreCategory = "Supermarket",
                      OperationalHours = "Monday-Friday 06:00AM-22:00PM, Saturday-Sunday 07:00AM-22:00PM",
                      ProvinceId = 3
                  },
                  new Store
                  {
                      Id = 4,
                      Name = "Jet Mart",
                      Address = "Jet Stores, 441-453 West St, Durban Central, Durban, 4001, South Africa",
                      PhoneNumber = "031 530 2120",
                      WhatsApp = "N/A",
                      Email = "Jetinfo@edcon.co.za",
                      Rating = 4.2,
                      StoreCategory = "Clothing & Retail",
                      OperationalHours = "Monday-Thursday 08:30AM-17:30PM, Friday 08:00AM-18:00PM, Saturday 08:00AM-17:00PM, Sunday 09:00AM-16:00PM",
                      ProvinceId = 4
                  },
                  new Store
                  {
                      Id = 5,
                      Name = "Spar Limpopo",
                      Address = "Cnr Hospital & Market St Shop 2, Game Shopping Centre, Polokwane, 1665, South Africa",
                      PhoneNumber = "015 297 4679",
                      WhatsApp = "N/A",
                      Email = "limpopo5@retail.spar.co.za",
                      Rating = 3.8,
                      StoreCategory = "Groceries",
                      OperationalHours = "Monday-Thursday 08:00AM-20:0PM, Friday 08:00AM-21:00PM, Saturday 08:00AM-20:00PM, Sunday 08:00AM-19:00PM",
                      ProvinceId = 5
                  },
                  new Store
                  {
                      Id = 6,
                      Name = "Forever New Riverside",
                      Address = "Shop 53, Riverside Mall, Cnr R40 White River Road & Govt Blvd, Nelspruit, Mpumalanga, 3699, South Africa",
                      PhoneNumber = "061 462 7818",
                      WhatsApp = "N/A",
                      Email = "info@forevernew.co.za",
                      Rating = 4.4,
                      StoreCategory = "Women's Clothing",
                      OperationalHours = "Monday-Saturday 09:00AM-18:00PM, Sunday 09:00AM-15:00PM",
                      ProvinceId = 6
                  },
                  new Store
                  {
                      Id = 7,
                      Name = "Mugg & Bean",
                      Address = "Shop 26A, Diamond Pavillion SC, Oliver Rd, Kimberley, 8300, South Africa",
                      PhoneNumber = "053 832 0521",
                      WhatsApp = "N/A",
                      Email = "info@muggandbean.co.za",
                      Rating = 4.0,
                      StoreCategory = "Restaurant",
                      OperationalHours = "Monday-Thursday 08:00AM-18:0PM, Friday 08:00AM-19:00PM, Saturday 08:00AM-17:00PM, Sunday 09:00AM-14:00PM",
                      ProvinceId = 7
                  },
                  new Store
                  {
                      Id = 8,
                      Name = "Markham North West Mall Mafikeng",
                      Address = "Shop 6 Northwest Mall Cnr Station Carrington Main & Martin Streets Mafikeng, Mahikeng, 2745, South Africa",
                      PhoneNumber = "018 381 3497",
                      WhatsApp = "N/A",
                      Email = "customerservices@tfg.co.za",
                      Rating = 4.5,
                      StoreCategory = "Men Clothing",
                      OperationalHours = "Monday-Friday 08:00AM-17:00PM, Saturday 09:00AM-14:00PM, Sunday 09:00AM-13:00PM",
                      ProvinceId = 8
                  },
                  new Store
                  {
                      Id = 9,
                      Name = "Elite Power Trade",
                      Address = " Reen Ave & Carrick Road, Hatton, Cape Town, 7766, South Africa",
                      PhoneNumber = "021 637 6810",
                      WhatsApp = "062 840 9367",
                      Email = "info@elitepowertrade.co.za",
                      Rating = 4.2,
                      StoreCategory = "Supermakret",
                      OperationalHours = "Monday-Friday 07:30AM-18:00PM, Saturday 07:30AM-17:00PM, Sunday 07:30AM-13:00PM",
                      ProvinceId = 9
                  }
            );
        }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<ShoppingCenter> ShoppingCenters { get; set; }
        public DbSet<Store> Stores { get; set; }


    }
}
