using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CountryApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class CountryDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Region = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Area = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Population = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Area", "Code", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Population", "Region" },
                values: new object[,]
                {
                    { 1, "783562", "TR", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8261), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8266), "Türkiye", 86968712, "Avrupa" },
                    { 2, "357022", "DE", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8269), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8269), "Almanya", 83783942, "Avrupa" },
                    { 3, "551695", "FR", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8272), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8273), "Fransa", 65273511, "Avrupa" },
                    { 4, "301340", "IT", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8275), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8276), "İtalya", 60244639, "Avrupa" },
                    { 5, "505992", "ES", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8279), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8279), "İspanya", 46754778, "Avrupa" },
                    { 6, "92212", "PT", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8282), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8282), "Portekiz", 10196709, "Avrupa" },
                    { 7, "41850", "NL", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8285), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8285), "Hollanda", 17134872, "Avrupa" },
                    { 8, "30528", "BE", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8288), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8288), "Belçika", 11589623, "Avrupa" },
                    { 9, "131957", "GR", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8291), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8291), "Yunanistan", 10423054, "Avrupa" },
                    { 10, "83879", "AT", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8294), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8294), "Avusturya", 8917205, "Avrupa" },
                    { 11, "17098242", "RU", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8296), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8297), "Rusya", 145912025, "Avrupa" },
                    { 12, "9596961", "CN", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8299), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8300), "Çin", 1393409038, "Asya" },
                    { 13, "377975", "JP", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8302), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8303), "Japonya", 126476461, "Asya" },
                    { 14, "3287263", "IN", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8305), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8306), "Hindistan", 1366417754, "Asya" },
                    { 15, "100032", "KR", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8308), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8309), "Güney Kore", 51269185, "Asya" },
                    { 16, "1904569", "ID", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8311), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8312), "Endonezya", 273523615, "Asya" },
                    { 17, "8515767", "BR", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8314), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8315), "Brezilya", 212559417, "Güney Amerika" },
                    { 18, "2780400", "AR", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8317), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8318), "Arjantin", 45195777, "Güney Amerika" },
                    { 19, "756102", "CL", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8320), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8321), "Şili", 19116209, "Güney Amerika" },
                    { 20, "1141748", "CO", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8323), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8324), "Kolombiya", 50882891, "Güney Amerika" },
                    { 21, "9976140", "CA", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8326), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8327), "Kanada", 37742154, "Kuzey Amerika" },
                    { 22, "1964375", "MX", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8329), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8329), "Meksika", 128932753, "Kuzey Amerika" },
                    { 23, "9372610", "US", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8332), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8332), "ABD", 331002651, "Kuzey Amerika" },
                    { 24, "7692024", "AU", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8335), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8335), "Avustralya", 25499884, "Okyanusya" },
                    { 25, "268021", "NZ", new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8338), true, false, new DateTime(2024, 9, 2, 22, 56, 26, 808, DateTimeKind.Utc).AddTicks(8338), "Yeni Zelanda", 4822233, "Okyanusya" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
