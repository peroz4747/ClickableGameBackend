using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClickableGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class newmigration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Power",
                table: "UserItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Power",
                table: "Items",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Power", "Price" },
                values: new object[] { "M16 Rifle", 30, 1200m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Power", "Price" },
                values: new object[] { "AK-47", 35, 700m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Power", "Price" },
                values: new object[] { "HK416", 38, 2500m });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name", "Power", "Price" },
                values: new object[,]
                {
                    { 4, "FN SCAR", 40, 3000m },
                    { 5, "Barrett M82", 50, 10000m },
                    { 6, "RPG-7", 45, 1200m },
                    { 7, "M4 Carbine", 35, 1500m },
                    { 8, "FN F2000", 38, 2300m },
                    { 9, "IWI Tavor", 40, 2800m },
                    { 10, "CZ BREN 2", 38, 2200m },
                    { 11, "M2 Browning", 50, 12000m },
                    { 12, "Desert Eagle", 25, 1800m },
                    { 13, "Glock 17", 20, 600m },
                    { 14, "Colt M1911", 22, 800m },
                    { 15, "M1 Abrams", 90, 7000000m },
                    { 16, "Leopard 2A7", 92, 8000000m },
                    { 17, "T-90", 85, 4000000m },
                    { 18, "Challenger 2", 88, 6000000m },
                    { 19, "Merkava Mk IV", 85, 6500000m },
                    { 20, "Type 99", 84, 5000000m },
                    { 21, "Leclerc", 87, 9000000m },
                    { 22, "K2 Black Panther", 90, 8500000m },
                    { 23, "T-14 Armata", 92, 7500000m },
                    { 24, "AMX-56 Leclerc", 88, 8500000m },
                    { 25, "PT-91 Twardy", 80, 4500000m },
                    { 26, "F-35 Lightning II", 95, 100000000m },
                    { 27, "Sukhoi Su-57", 90, 90000000m },
                    { 28, "F-22 Raptor", 98, 120000000m },
                    { 29, "Eurofighter Typhoon", 85, 80000000m },
                    { 30, "Dassault Rafale", 84, 75000000m },
                    { 31, "J-20 Mighty Dragon", 88, 90000000m },
                    { 32, "Saab Gripen", 80, 60000000m },
                    { 33, "F/A-18 Super Hornet", 87, 75000000m },
                    { 34, "MiG-35", 82, 45000000m },
                    { 35, "F-16 Fighting Falcon", 80, 40000000m },
                    { 36, "F-15 Eagle", 85, 60000000m },
                    { 37, "Su-35 Flanker-E", 85, 50000000m },
                    { 38, "A-10 Thunderbolt II", 70, 18000000m },
                    { 39, "B-2 Spirit Bomber", 98, 1500000000m },
                    { 40, "B-52 Stratofortress", 85, 100000000m },
                    { 41, "Arleigh Burke Destroyer", 80, 1500000000m },
                    { 42, "Zumwalt-Class Destroyer", 85, 4000000000m },
                    { 43, "Nimitz-Class Aircraft Carrier", 98, 9000000000m },
                    { 44, "Ford-Class Aircraft Carrier", 100, 13000000000m },
                    { 45, "Queen Elizabeth-Class Carrier", 95, 6500000000m },
                    { 46, "Type 45 Destroyer", 80, 1200000000m },
                    { 47, "Admiral Gorshkov-Class Frigate", 75, 500000000m },
                    { 48, "LCS Freedom-Class", 70, 400000000m },
                    { 49, "Seawolf-Class Submarine", 95, 3000000000m },
                    { 50, "Virginia-Class Submarine", 90, 2700000000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DropColumn(
                name: "Power",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "Items");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Tank", 100000m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Airplane", 10000000m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Ship", 1000000m });
        }
    }
}
