using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreLoc.APIData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreLoc.LocatorDataEntities
{
    public class ShoppingCenterConfig : IEntityTypeConfiguration<ShoppingCenter>
    {
        public void Configure(EntityTypeBuilder<ShoppingCenter> builder)
        {
            builder.HasData(
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
        }
    }
}
