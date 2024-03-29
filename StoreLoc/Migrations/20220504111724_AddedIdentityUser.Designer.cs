﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreLoc.APIData;

namespace StoreLoc.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220504111724_AddedIdentityUser")]
    partial class AddedIdentityUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StoreLoc.APIData.APIUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("StoreLoc.APIData.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Provinces");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Eastern Cape",
                            ShortName = "EC"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Free State",
                            ShortName = "FS"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Gauteng",
                            ShortName = "GP"
                        },
                        new
                        {
                            Id = 4,
                            Name = "KwaZulu-Natal",
                            ShortName = "KZN"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Limpopo",
                            ShortName = "LP"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Mpumalanga",
                            ShortName = "MP"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Northern Cape",
                            ShortName = "NC"
                        },
                        new
                        {
                            Id = 8,
                            Name = "North West",
                            ShortName = "NW"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Western Cape",
                            ShortName = "WC"
                        });
                });

            modelBuilder.Entity("StoreLoc.APIData.ShoppingCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationalHours")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("ShoppingCenters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cnr. Baird & Gerald Smith St, Uitenhage Central, Uitenhage, 6229, Eastern Cape, South Africa",
                            Name = "Binnehof Centre",
                            OperationalHours = "Monday-Saturday 09:00AM-16:00PM, Sunday 09:00AM-13:00PM",
                            PhoneNumber = "041 363 3621",
                            ProvinceId = 1,
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 2,
                            Address = "Vereeniging Dr, Fleurdal, Bloemfontein, 9301, South Africa",
                            Name = "Fleurdal Mall",
                            OperationalHours = "Monday-Friday 08:30AM-18:00PM, Saturday 08:00AM-17:00PM, Sunday 08:00AM-14:00PM",
                            PhoneNumber = "051 522 8141",
                            ProvinceId = 2,
                            Rating = 4.2000000000000002
                        },
                        new
                        {
                            Id = 3,
                            Address = "Eastgate Shopping Centre, 43 Bradford Rd, Bedfordview, Germiston, 2008, South Africa",
                            Name = "Eastgate Shopping Centre",
                            OperationalHours = "Monday-Sunday 09:00AM-19:00PM, Friday 09:00AM-21:00PM",
                            PhoneNumber = "011 479 6000",
                            ProvinceId = 3,
                            Rating = 4.4000000000000004
                        },
                        new
                        {
                            Id = 4,
                            Address = "1 Palm Blvd, Umhlanga Ridge, Umhlanga, 4021, KwaZulu-Natal, South Africa",
                            Name = "Gateway Theatre Of Shopping",
                            OperationalHours = "Monday-Thursday 09:00AM-19:00PM, Friday-Saturday 09:00AM-21:00PM, Sunday 09:00AM-18:00PM",
                            PhoneNumber = "031 514 0500",
                            ProvinceId = 4,
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 5,
                            Address = "R81, Bendor, Polokwane, 0699, Limpopo, South Africa",
                            Name = "Mall of the North",
                            OperationalHours = "Monday-Friday 09:00AM-19:00PM, Saturday-Sunday 09:00AM-17:00PM",
                            PhoneNumber = "015 265 1026",
                            ProvinceId = 5,
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 6,
                            Address = "X38, Corner of Bitterbessie &, Flamboyant St, West Acres, Mbombela, 1200, Mpumalanga, South Africa",
                            Name = "i’langa Mall",
                            OperationalHours = "Monday-Saturday 09:00AM-18:00PM, Sunday 09:00AM-15:00PM",
                            PhoneNumber = "013 742 2293 or 013 742 2294",
                            ProvinceId = 6,
                            Rating = 4.4000000000000004
                        },
                        new
                        {
                            Id = 7,
                            Address = "Cnr Oliver &, Mac Dougall St, Roads, Kimberley, 8301, Northern Cape, South Africa",
                            Name = "Diamond Pavilion Shopping Centre",
                            OperationalHours = "Monday-Thursday 09:00AM-18:00PM, Friday 09:00AM-19:00PM, Saturday 09:00AM-17:00PM, Sunday 09:00AM-18:00PM",
                            PhoneNumber = "053 832 9200",
                            ProvinceId = 7,
                            Rating = 4.2999999999999998
                        },
                        new
                        {
                            Id = 8,
                            Address = "Nelson Mandela Dr, Potchefstroom, 2531, North West, South Africa",
                            Name = "MooiRivier Mall",
                            OperationalHours = "Monday-Saturday 09:00AM-18:00PM, Sunday 09:00AM-15:00PM",
                            PhoneNumber = "018 293 2004",
                            ProvinceId = 8,
                            Rating = 4.2999999999999998
                        },
                        new
                        {
                            Id = 9,
                            Address = "490 Century Blvd, Century City, Cape Town, 7446, Western Cape, South Africa",
                            Name = "Canal Walk",
                            OperationalHours = "Monday-Sunday 09:00AM-21:00PM",
                            PhoneNumber = "021 529 9699",
                            ProvinceId = 9,
                            Rating = 4.4000000000000004
                        });
                });

            modelBuilder.Entity("StoreLoc.APIData.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationalHours")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("StoreCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhatsApp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "	Flagstaff, Ingquza Hill, 4810, Eastern Cape, South Africa",
                            Email = "xtrasavings@shoprite.co.za",
                            Name = "Shoprite Flagstaff",
                            OperationalHours = "Monday-Friday 09:00AM-18:00PM, Saturday-Sunday 08:00AM-17:00PM",
                            PhoneNumber = "039 252 7350",
                            ProvinceId = 1,
                            Rating = 1.7,
                            StoreCategory = "Food & Retail",
                            WhatsApp = "087 240 5709"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Corner Eland Street, and N8 National Road Bloemfontein 9324, South Africa",
                            Email = "makrocare@makro.co.za",
                            Name = "Makro",
                            OperationalHours = "Monday-Friday 09:00AM-18:00PM, Saturday 08:30AM-16:00PM, Sunday 09:00AM-13:00PM",
                            PhoneNumber = "0860 300 999",
                            ProvinceId = 2,
                            Rating = 4.0999999999999996,
                            StoreCategory = "Wholesale(Cash & Carry)",
                            WhatsApp = "0860 300 999"
                        },
                        new
                        {
                            Id = 3,
                            Address = "7 Siemert Rd, Doornfontein, Johannesburg, 2094, South Africa",
                            Email = "bigtimebutchery@gmail.com",
                            Name = "Big Time Butchery & Supermarket",
                            OperationalHours = "Monday-Friday 06:00AM-22:00PM, Saturday-Sunday 07:00AM-22:00PM",
                            PhoneNumber = "011 402 0177",
                            ProvinceId = 3,
                            Rating = 4.2000000000000002,
                            StoreCategory = "Supermarket",
                            WhatsApp = "N/A"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Jet Stores, 441-453 West St, Durban Central, Durban, 4001, South Africa",
                            Email = "Jetinfo@edcon.co.za",
                            Name = "Jet Mart",
                            OperationalHours = "Monday-Thursday 08:30AM-17:30PM, Friday 08:00AM-18:00PM, Saturday 08:00AM-17:00PM, Sunday 09:00AM-16:00PM",
                            PhoneNumber = "031 530 2120",
                            ProvinceId = 4,
                            Rating = 4.2000000000000002,
                            StoreCategory = "Clothing & Retail",
                            WhatsApp = "N/A"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Cnr Hospital & Market St Shop 2, Game Shopping Centre, Polokwane, 1665, South Africa",
                            Email = "limpopo5@retail.spar.co.za",
                            Name = "Spar Limpopo",
                            OperationalHours = "Monday-Thursday 08:00AM-20:0PM, Friday 08:00AM-21:00PM, Saturday 08:00AM-20:00PM, Sunday 08:00AM-19:00PM",
                            PhoneNumber = "015 297 4679",
                            ProvinceId = 5,
                            Rating = 3.7999999999999998,
                            StoreCategory = "Groceries",
                            WhatsApp = "N/A"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Shop 53, Riverside Mall, Cnr R40 White River Road & Govt Blvd, Nelspruit, Mpumalanga, 3699, South Africa",
                            Email = "info@forevernew.co.za",
                            Name = "Forever New Riverside",
                            OperationalHours = "Monday-Saturday 09:00AM-18:00PM, Sunday 09:00AM-15:00PM",
                            PhoneNumber = "061 462 7818",
                            ProvinceId = 6,
                            Rating = 4.4000000000000004,
                            StoreCategory = "Women's Clothing",
                            WhatsApp = "N/A"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Shop 26A, Diamond Pavillion SC, Oliver Rd, Kimberley, 8300, South Africa",
                            Email = "info@muggandbean.co.za",
                            Name = "Mugg & Bean",
                            OperationalHours = "Monday-Thursday 08:00AM-18:0PM, Friday 08:00AM-19:00PM, Saturday 08:00AM-17:00PM, Sunday 09:00AM-14:00PM",
                            PhoneNumber = "053 832 0521",
                            ProvinceId = 7,
                            Rating = 4.0,
                            StoreCategory = "Restaurant",
                            WhatsApp = "N/A"
                        },
                        new
                        {
                            Id = 8,
                            Address = "Shop 6 Northwest Mall Cnr Station Carrington Main & Martin Streets Mafikeng, Mahikeng, 2745, South Africa",
                            Email = "customerservices@tfg.co.za",
                            Name = "Markham North West Mall Mafikeng",
                            OperationalHours = "Monday-Friday 08:00AM-17:00PM, Saturday 09:00AM-14:00PM, Sunday 09:00AM-13:00PM",
                            PhoneNumber = "018 381 3497",
                            ProvinceId = 8,
                            Rating = 4.5,
                            StoreCategory = "Men Clothing",
                            WhatsApp = "N/A"
                        },
                        new
                        {
                            Id = 9,
                            Address = " Reen Ave & Carrick Road, Hatton, Cape Town, 7766, South Africa",
                            Email = "info@elitepowertrade.co.za",
                            Name = "Elite Power Trade",
                            OperationalHours = "Monday-Friday 07:30AM-18:00PM, Saturday 07:30AM-17:00PM, Sunday 07:30AM-13:00PM",
                            PhoneNumber = "021 637 6810",
                            ProvinceId = 9,
                            Rating = 4.2000000000000002,
                            StoreCategory = "Supermakret",
                            WhatsApp = "062 840 9367"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("StoreLoc.APIData.APIUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StoreLoc.APIData.APIUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreLoc.APIData.APIUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StoreLoc.APIData.APIUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StoreLoc.APIData.ShoppingCenter", b =>
                {
                    b.HasOne("StoreLoc.APIData.Province", "Province")
                        .WithMany("ShoppingCenters")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("StoreLoc.APIData.Store", b =>
                {
                    b.HasOne("StoreLoc.APIData.Province", "Province")
                        .WithMany("Stores")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("StoreLoc.APIData.Province", b =>
                {
                    b.Navigation("ShoppingCenters");

                    b.Navigation("Stores");
                });
#pragma warning restore 612, 618
        }
    }
}
