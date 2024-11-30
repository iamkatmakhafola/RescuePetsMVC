using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace u21503193_HW02.Migrations
{
    /// <inheritdoc />
    public partial class _2nd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4742), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4747), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4750), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4752), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4754), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4756), 0 });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4400));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
