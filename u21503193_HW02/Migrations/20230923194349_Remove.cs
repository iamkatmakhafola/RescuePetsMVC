using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace u21503193_HW02.Migrations
{
    /// <inheritdoc />
    public partial class Remove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropIndex(
                name: "IX_Adoptions_UserId",
                table: "Adoptions");

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 43, 48, 925, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 43, 48, 925, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 43, 48, 925, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 43, 48, 925, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 43, 48, 925, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 43, 48, 925, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 43, 48, 925, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 43, 48, 925, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 43, 48, 925, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 43, 48, 925, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 43, 48, 925, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 21, 43, 48, 925, DateTimeKind.Local).AddTicks(3420));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 23, 21, 21, 27, 674, DateTimeKind.Local).AddTicks(4756));

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

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_UserId",
                table: "Adoptions",
                column: "UserId");

            
        }
    }
}
