using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace u21503193_HW02.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(933), "/images/pet1.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(958), "/images/pet2.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(964), "/images/pet3.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(968), "/images/pet4.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(973), "/images/pet5.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(978), "/images/pet6.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2207), "~/images/pet1.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2227), "~/images/pet2.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2230), "~/images/pet3.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2232), "~/images/pet4.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2234), "~/images/pet5.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2236), "~/images/pet6.jpg" });
        }
    }
}
