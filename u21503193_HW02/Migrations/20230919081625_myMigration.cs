using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace u21503193_HW02.Migrations
{
    /// <inheritdoc />
    public partial class myMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PetStory = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adoptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    AdoptionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adoptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adoptions_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "CreatedDate", "Gender", "ImageUrl", "Location", "Name", "PetStory", "Status", "Type", "Weight" },
                values: new object[,]
                {
                    { 1, 2, "Labrador", new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3338), "Male", "/images/pet1.jpg", "Gauteng", "Buddy", "Buddy is a friendly Labrador looking for a loving home. He enjoys long walks and playing fetch.", "Available", "Dog", 25.0m },
                    { 2, 1, "Siamese", new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3362), "Female", "/images/pet2.jpg", "Cape Town", "Whiskers", "Whiskers is a playful Siamese cat with a sweet disposition. She loves cuddling and chasing toy mice.", "Adopted", "Cat", 10.0m },
                    { 3, 3, "Golden Retriever", new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3367), "Male", "/images/pet3.jpg", "Durban", "Rocky", "Rocky is an energetic Golden Retriever who enjoys outdoor adventures and fetching tennis balls.", "Available", "Dog", 30.0m },
                    { 4, 2, "Persian", new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3372), "Female", "/images/pet4.jpg", "Cape Town", "Mittens", "Mittens is a graceful Persian cat known for her luxurious fur and elegant demeanor.", "Available", "Cat", 12.0m },
                    { 5, 1, "Dachshund", new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3377), "Female", "/images/pet5.jpg", "Gauteng", "Charlie", "Charlie is a playful Dachshund who loves going on adventures and meeting new people.", "Adopted", "Dog", 15.0m },
                    { 6, 2, "Cockatiel", new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3382), "Male", "/images/pet6.jpg", "Durban", "Kiwi", "Kiwi is a colorful Cockatiel with a cheerful personality. He enjoys singing and mimicking sounds.", "Available", "Bird", 0.2m }
                });

            migrationBuilder.InsertData(
                table: "Adoptions",
                columns: new[] { "Id", "AdoptionDate", "PetId", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3693), 1, "John" },
                    { 2, new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3698), 2, "Jane" },
                    { 3, new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3701), 3, "Michael" },
                    { 4, new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3703), 4, "Emily" },
                    { 5, new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3706), 5, "David" },
                    { 6, new DateTime(2023, 9, 19, 10, 16, 25, 735, DateTimeKind.Local).AddTicks(3708), 6, "Sarah" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_PetId",
                table: "Adoptions",
                column: "PetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adoptions");

            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
