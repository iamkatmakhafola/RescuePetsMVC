using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace u21503193_HW02.Migrations
{
    /// <inheritdoc />
    public partial class SeedDonations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonationAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Donations",
                columns: new[] { "Id", "DonationAmount", "DonationDate", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 50.00m, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Alice Johnson", "0611234567" },
                    { 2, 100.00m, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Bob Smith", "0617654321" },
                    { 3, 25.00m, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Charlie Brown", "0711234567" },
                    { 4, 75.00m, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "David Wilson", "0717654321" },
                    { 5, 200.00m, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Ella Davis", "0811234567" },
                    { 6, 30.00m, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Frank Martin", "0817654321" }
                });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 51, 11, 748, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 51, 11, 748, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 51, 11, 748, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 51, 11, 748, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 51, 11, 748, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 51, 11, 748, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 51, 11, 748, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 51, 11, 748, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 51, 11, 748, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 51, 11, 748, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 51, 11, 748, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 51, 11, 748, DateTimeKind.Local).AddTicks(2613));
        }
    }
}
