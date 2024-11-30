using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace u21503193_HW02.Migrations
{
    /// <inheritdoc />
    public partial class _1stMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Adoptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 1, 50, 20, 931, DateTimeKind.Local).AddTicks(1995), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 1, 50, 20, 931, DateTimeKind.Local).AddTicks(2002), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 1, 50, 20, 931, DateTimeKind.Local).AddTicks(2005), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 1, 50, 20, 931, DateTimeKind.Local).AddTicks(2007), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 1, 50, 20, 931, DateTimeKind.Local).AddTicks(2009), 0 });

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdoptionDate", "UserId" },
                values: new object[] { new DateTime(2023, 9, 23, 1, 50, 20, 931, DateTimeKind.Local).AddTicks(2011), 0 });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 1, 50, 20, 931, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 1, 50, 20, 931, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 1, 50, 20, 931, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 1, 50, 20, 931, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 1, 50, 20, 931, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 1, 50, 20, 931, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PhoneNumber",
                value: "0611111111");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "PhoneNumber",
                value: "0712222222");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "PhoneNumber",
                value: "0813333333");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "PhoneNumber",
                value: "0614444444");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "PhoneNumber",
                value: "0715555555");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "PhoneNumber",
                value: "0816666666");

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_UserId",
                table: "Adoptions",
                column: "UserId");

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropIndex(
                name: "IX_Adoptions_UserId",
                table: "Adoptions");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Adoptions");

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
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 20, 39, 17, 558, DateTimeKind.Local).AddTicks(978));
        }
    }
}
