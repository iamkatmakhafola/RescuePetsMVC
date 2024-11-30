using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace u21503193_HW02.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

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
                columns: new[] { "CreatedDate", "ImageUrl", "UserId" },
                values: new object[] { new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2207), "~/images/pet1.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "UserId" },
                values: new object[] { new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2227), "~/images/pet2.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "UserId" },
                values: new object[] { new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2230), "~/images/pet3.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl", "UserId" },
                values: new object[] { new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2232), "~/images/pet4.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl", "UserId" },
                values: new object[] { new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2234), "~/images/pet5.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImageUrl", "UserId" },
                values: new object[] { new DateTime(2023, 9, 20, 13, 6, 18, 118, DateTimeKind.Local).AddTicks(2236), "~/images/pet6.jpg", 6 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Emily", "Johnson" },
                    { 2, "David", "Smith" },
                    { 3, "Sophia", "Brown" },
                    { 4, "Oliver", "Davis" },
                    { 5, "Ava", "Wilson" },
                    { 6, "Lucas", "Miller" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_UserId",
                table: "Pets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Users_UserId",
                table: "Pets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Users_UserId",
                table: "Pets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Pets_UserId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Pets");

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Adoptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "AdoptionDate",
                value: new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3338), "/images/pet1.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3362), "/images/pet2.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3367), "/images/pet3.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3372), "/images/pet4.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3377), "/images/pet5.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3382), "/images/pet6.jpg" });
        }
    }
}
