﻿// <auto-generated />
using System;
using CountryApi.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CountryApi.Data.Migrations
{
    [DbContext(typeof(CountryContext))]
    [Migration("20240902225627_CountryDb")]
    partial class CountryDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("CountryApi.Entity.Concrete.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Population")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Area = "783562",
                            Code = "TR",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8261),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8266),
                            Name = "Türkiye",
                            Population = 86968712,
                            Region = "Avrupa"
                        },
                        new
                        {
                            Id = 2,
                            Area = "357022",
                            Code = "DE",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8269),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8269),
                            Name = "Almanya",
                            Population = 83783942,
                            Region = "Avrupa"
                        },
                        new
                        {
                            Id = 3,
                            Area = "551695",
                            Code = "FR",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8272),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8273),
                            Name = "Fransa",
                            Population = 65273511,
                            Region = "Avrupa"
                        },
                        new
                        {
                            Id = 4,
                            Area = "301340",
                            Code = "IT",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8275),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8276),
                            Name = "İtalya",
                            Population = 60244639,
                            Region = "Avrupa"
                        },
                        new
                        {
                            Id = 5,
                            Area = "505992",
                            Code = "ES",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8279),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8279),
                            Name = "İspanya",
                            Population = 46754778,
                            Region = "Avrupa"
                        },
                        new
                        {
                            Id = 6,
                            Area = "92212",
                            Code = "PT",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8282),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8282),
                            Name = "Portekiz",
                            Population = 10196709,
                            Region = "Avrupa"
                        },
                        new
                        {
                            Id = 7,
                            Area = "41850",
                            Code = "NL",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8285),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8285),
                            Name = "Hollanda",
                            Population = 17134872,
                            Region = "Avrupa"
                        },
                        new
                        {
                            Id = 8,
                            Area = "30528",
                            Code = "BE",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8288),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8288),
                            Name = "Belçika",
                            Population = 11589623,
                            Region = "Avrupa"
                        },
                        new
                        {
                            Id = 9,
                            Area = "131957",
                            Code = "GR",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8291),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8291),
                            Name = "Yunanistan",
                            Population = 10423054,
                            Region = "Avrupa"
                        },
                        new
                        {
                            Id = 10,
                            Area = "83879",
                            Code = "AT",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8294),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8294),
                            Name = "Avusturya",
                            Population = 8917205,
                            Region = "Avrupa"
                        },
                        new
                        {
                            Id = 11,
                            Area = "17098242",
                            Code = "RU",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8296),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8297),
                            Name = "Rusya",
                            Population = 145912025,
                            Region = "Avrupa"
                        },
                        new
                        {
                            Id = 12,
                            Area = "9596961",
                            Code = "CN",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8299),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8300),
                            Name = "Çin",
                            Population = 1393409038,
                            Region = "Asya"
                        },
                        new
                        {
                            Id = 13,
                            Area = "377975",
                            Code = "JP",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8302),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8303),
                            Name = "Japonya",
                            Population = 126476461,
                            Region = "Asya"
                        },
                        new
                        {
                            Id = 14,
                            Area = "3287263",
                            Code = "IN",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8305),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8306),
                            Name = "Hindistan",
                            Population = 1366417754,
                            Region = "Asya"
                        },
                        new
                        {
                            Id = 15,
                            Area = "100032",
                            Code = "KR",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8308),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8309),
                            Name = "Güney Kore",
                            Population = 51269185,
                            Region = "Asya"
                        },
                        new
                        {
                            Id = 16,
                            Area = "1904569",
                            Code = "ID",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8311),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8312),
                            Name = "Endonezya",
                            Population = 273523615,
                            Region = "Asya"
                        },
                        new
                        {
                            Id = 17,
                            Area = "8515767",
                            Code = "BR",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8314),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8315),
                            Name = "Brezilya",
                            Population = 212559417,
                            Region = "Güney Amerika"
                        },
                        new
                        {
                            Id = 18,
                            Area = "2780400",
                            Code = "AR",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8317),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8318),
                            Name = "Arjantin",
                            Population = 45195777,
                            Region = "Güney Amerika"
                        },
                        new
                        {
                            Id = 19,
                            Area = "756102",
                            Code = "CL",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8320),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8321),
                            Name = "Şili",
                            Population = 19116209,
                            Region = "Güney Amerika"
                        },
                        new
                        {
                            Id = 20,
                            Area = "1141748",
                            Code = "CO",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8323),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8324),
                            Name = "Kolombiya",
                            Population = 50882891,
                            Region = "Güney Amerika"
                        },
                        new
                        {
                            Id = 21,
                            Area = "9976140",
                            Code = "CA",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8326),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8327),
                            Name = "Kanada",
                            Population = 37742154,
                            Region = "Kuzey Amerika"
                        },
                        new
                        {
                            Id = 22,
                            Area = "1964375",
                            Code = "MX",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8329),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8329),
                            Name = "Meksika",
                            Population = 128932753,
                            Region = "Kuzey Amerika"
                        },
                        new
                        {
                            Id = 23,
                            Area = "9372610",
                            Code = "US",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8332),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8332),
                            Name = "ABD",
                            Population = 331002651,
                            Region = "Kuzey Amerika"
                        },
                        new
                        {
                            Id = 24,
                            Area = "7692024",
                            Code = "AU",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8335),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8335),
                            Name = "Avustralya",
                            Population = 25499884,
                            Region = "Okyanusya"
                        },
                        new
                        {
                            Id = 25,
                            Area = "268021",
                            Code = "NZ",
                            CreatedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8338),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8338),
                            Name = "Yeni Zelanda",
                            Population = 4822233,
                            Region = "Okyanusya"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
