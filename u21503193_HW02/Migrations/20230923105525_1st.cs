using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace u21503193_HW02.Migrations
{
    /// <inheritdoc />
    public partial class _1st : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 12, 55, 25, 751, DateTimeKind.Local).AddTicks(6596), 1 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 12, 55, 25, 751, DateTimeKind.Local).AddTicks(6604), 2 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 12, 55, 25, 751, DateTimeKind.Local).AddTicks(6607), 3 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 12, 55, 25, 751, DateTimeKind.Local).AddTicks(6610), 4 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 12, 55, 25, 751, DateTimeKind.Local).AddTicks(6613), 5 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 12, 55, 25, 751, DateTimeKind.Local).AddTicks(6616), 6 });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 12, 55, 25, 751, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 12, 55, 25, 751, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 12, 55, 25, 751, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 12, 55, 25, 751, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 12, 55, 25, 751, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 12, 55, 25, 751, DateTimeKind.Local).AddTicks(6271));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 12, 40, 25, 500, DateTimeKind.Local).AddTicks(1381), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 12, 40, 25, 500, DateTimeKind.Local).AddTicks(1387), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 12, 40, 25, 500, DateTimeKind.Local).AddTicks(1389), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 12, 40, 25, 500, DateTimeKind.Local).AddTicks(1391), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 12, 40, 25, 500, DateTimeKind.Local).AddTicks(1393), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 12, 40, 25, 500, DateTimeKind.Local).AddTicks(1395), 0 });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 12, 40, 25, 500, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 12, 40, 25, 500, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 12, 40, 25, 500, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 12, 40, 25, 500, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 12, 40, 25, 500, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 12, 40, 25, 500, DateTimeKind.Local).AddTicks(1137));
        }
    }
}
