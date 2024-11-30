﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using u21503193_HW02.Data;

#nullable disable

namespace u21503193_HW02.Migrations
{
    [DbContext(typeof(DBPetContext))]
    [Migration("20230930191920_SeedDonations")]
    partial class SeedDonations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("u21503193_HW02.Models.Adoption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AdoptionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<int>("UseId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("Adoptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdoptionDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            PetId = 1,
                            UseId = 0,
                            UserName = "John"
                        },
                        new
                        {
                            Id = 2,
                            AdoptionDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            PetId = 2,
                            UseId = 0,
                            UserName = "Jane"
                        },
                        new
                        {
                            Id = 3,
                            AdoptionDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            PetId = 3,
                            UseId = 0,
                            UserName = "Michael"
                        },
                        new
                        {
                            Id = 4,
                            AdoptionDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            PetId = 4,
                            UseId = 0,
                            UserName = "Emily"
                        },
                        new
                        {
                            Id = 5,
                            AdoptionDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            PetId = 5,
                            UseId = 0,
                            UserName = "David"
                        },
                        new
                        {
                            Id = 6,
                            AdoptionDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            PetId = 6,
                            UseId = 0,
                            UserName = "Sarah"
                        });
                });

            modelBuilder.Entity("u21503193_HW02.Models.Donation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("DonationAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DonationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Donations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DonationAmount = 50.00m,
                            DonationDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            FullName = "Alice Johnson",
                            PhoneNumber = "0611234567"
                        },
                        new
                        {
                            Id = 2,
                            DonationAmount = 100.00m,
                            DonationDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            FullName = "Bob Smith",
                            PhoneNumber = "0617654321"
                        },
                        new
                        {
                            Id = 3,
                            DonationAmount = 25.00m,
                            DonationDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            FullName = "Charlie Brown",
                            PhoneNumber = "0711234567"
                        },
                        new
                        {
                            Id = 4,
                            DonationAmount = 75.00m,
                            DonationDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            FullName = "David Wilson",
                            PhoneNumber = "0717654321"
                        },
                        new
                        {
                            Id = 5,
                            DonationAmount = 200.00m,
                            DonationDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            FullName = "Ella Davis",
                            PhoneNumber = "0811234567"
                        },
                        new
                        {
                            Id = 6,
                            DonationAmount = 30.00m,
                            DonationDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            FullName = "Frank Martin",
                            PhoneNumber = "0817654321"
                        });
                });

            modelBuilder.Entity("u21503193_HW02.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PetStory")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 2,
                            Breed = "Labrador",
                            CreatedDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Gender = "Male",
                            ImageUrl = "/images/pet1.jpg",
                            Location = "Gauteng",
                            Name = "Buddy",
                            PetStory = "Buddy is a friendly Labrador looking for a loving home. He enjoys long walks and playing fetch.",
                            Status = "Available",
                            Type = "Dog",
                            UserId = 1,
                            Weight = 25.0m
                        },
                        new
                        {
                            Id = 2,
                            Age = 1,
                            Breed = "Siamese",
                            CreatedDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Gender = "Female",
                            ImageUrl = "/images/pet2.jpg",
                            Location = "Cape Town",
                            Name = "Whiskers",
                            PetStory = "Whiskers is a playful Siamese cat with a sweet disposition. She loves cuddling and chasing toy mice.",
                            Status = "Adopted",
                            Type = "Cat",
                            UserId = 2,
                            Weight = 10.0m
                        },
                        new
                        {
                            Id = 3,
                            Age = 3,
                            Breed = "Golden Retriever",
                            CreatedDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Gender = "Male",
                            ImageUrl = "/images/pet3.jpg",
                            Location = "Durban",
                            Name = "Rocky",
                            PetStory = "Rocky is an energetic Golden Retriever who enjoys outdoor adventures and fetching tennis balls.",
                            Status = "Available",
                            Type = "Dog",
                            UserId = 3,
                            Weight = 30.0m
                        },
                        new
                        {
                            Id = 4,
                            Age = 2,
                            Breed = "Persian",
                            CreatedDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Gender = "Female",
                            ImageUrl = "/images/pet4.jpg",
                            Location = "Cape Town",
                            Name = "Mittens",
                            PetStory = "Mittens is a graceful Persian cat known for her luxurious fur and elegant demeanor.",
                            Status = "Available",
                            Type = "Cat",
                            UserId = 4,
                            Weight = 12.0m
                        },
                        new
                        {
                            Id = 5,
                            Age = 1,
                            Breed = "Dachshund",
                            CreatedDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Gender = "Female",
                            ImageUrl = "/images/pet5.jpg",
                            Location = "Gauteng",
                            Name = "Charlie",
                            PetStory = "Charlie is a playful Dachshund who loves going on adventures and meeting new people.",
                            Status = "Adopted",
                            Type = "Dog",
                            UserId = 5,
                            Weight = 15.0m
                        },
                        new
                        {
                            Id = 6,
                            Age = 2,
                            Breed = "Cockatiel",
                            CreatedDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Gender = "Male",
                            ImageUrl = "/images/pet6.jpg",
                            Location = "Durban",
                            Name = "Kiwi",
                            PetStory = "Kiwi is a colorful Cockatiel with a cheerful personality. He enjoys singing and mimicking sounds.",
                            Status = "Available",
                            Type = "Bird",
                            UserId = 6,
                            Weight = 0.2m
                        });
                });

            modelBuilder.Entity("u21503193_HW02.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Emily",
                            LastName = "Johnson",
                            PhoneNumber = "0611111111"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "David",
                            LastName = "Smith",
                            PhoneNumber = "0712222222"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Sophia",
                            LastName = "Brown",
                            PhoneNumber = "0813333333"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Oliver",
                            LastName = "Davis",
                            PhoneNumber = "0614444444"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Ava",
                            LastName = "Wilson",
                            PhoneNumber = "0715555555"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Lucas",
                            LastName = "Miller",
                            PhoneNumber = "0816666666"
                        });
                });

            modelBuilder.Entity("u21503193_HW02.Models.Adoption", b =>
                {
                    b.HasOne("u21503193_HW02.Models.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("u21503193_HW02.Models.Pet", b =>
                {
                    b.HasOne("u21503193_HW02.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
