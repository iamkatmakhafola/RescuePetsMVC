using Microsoft.EntityFrameworkCore;
using u21503193_HW02.Models;

namespace u21503193_HW02.Data
{
    public class DBPetContext: DbContext
    {
        public DBPetContext(DbContextOptions <DBPetContext> options) : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Donation> Donations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pet>()
            .HasOne(p => p.User)
            .WithMany()
            .HasForeignKey(p => p.UserId);


            modelBuilder.Entity<Pet>().Property(p => p.Weight)
            .HasColumnType("decimal(10,2)");

            modelBuilder.Entity<Pet>().HasData(
                new Pet
                {
                    Id = 1,
                    Name = "Buddy",
                    Type = "Dog",
                    Breed = "Labrador",
                    Location = "Gauteng",
                    Age = 2,
                    Weight = 25.0M,
                    Gender = "Male",
                    Status = "Available",
                    ImageUrl = "/images/pet1.jpg",
                    PetStory = "Buddy is a friendly Labrador looking for a loving home. He enjoys long walks and playing fetch.",
                    CreatedDate = DateTime.Now.Date,
                    UserId = 1
                },
                new Pet
                {
                    Id = 2,
                    Name = "Whiskers",
                    Type = "Cat",
                    Breed = "Siamese",
                    Location = "Cape Town",
                    Age = 1,
                    Weight = 10.0M,
                    Gender = "Female",
                    Status = "Adopted",
                    ImageUrl = "/images/pet2.jpg",
                    PetStory = "Whiskers is a playful Siamese cat with a sweet disposition. She loves cuddling and chasing toy mice.",
                    CreatedDate = DateTime.Now.Date,
                    UserId = 2
                },
                new Pet
                {
                    Id = 3,
                    Name = "Rocky",
                    Type = "Dog",
                    Breed = "Golden Retriever",
                    Location = "Durban",
                    Age = 3,
                    Weight = 30.0M,
                    Gender = "Male",
                    Status = "Available",
                    ImageUrl = "/images/pet3.jpg",
                    PetStory = "Rocky is an energetic Golden Retriever who enjoys outdoor adventures and fetching tennis balls.",
                    CreatedDate = DateTime.Now.Date,
                    UserId = 3
                },
                new Pet
                {
                    Id = 4,
                    Name = "Mittens",
                    Type = "Cat",
                    Breed = "Persian",
                    Location = "Cape Town",
                    Age = 2,
                    Weight = 12.0M,
                    Gender = "Female",
                    Status = "Available",
                    ImageUrl = "/images/pet4.jpg",
                    PetStory = "Mittens is a graceful Persian cat known for her luxurious fur and elegant demeanor.",
                    CreatedDate = DateTime.Now.Date,
                    UserId = 4
                },
                new Pet
                {
                    Id = 5,
                    Name = "Charlie",
                    Type = "Dog",
                    Breed = "Dachshund",
                    Location = "Gauteng",
                    Age = 1,
                    Weight = 15.0M,
                    Gender = "Female",
                    Status = "Adopted",
                    ImageUrl = "/images/pet5.jpg",
                    PetStory = "Charlie is a playful Dachshund who loves going on adventures and meeting new people.",
                    CreatedDate = DateTime.Now.Date,
                    UserId = 5
                },
                new Pet
                {
                    Id = 6,
                    Name = "Kiwi",
                    Type = "Bird",
                    Breed = "Cockatiel",
                    Location = "Durban",
                    Age = 2,
                    Weight = 0.2M,
                    Gender = "Male",
                    Status = "Available",
                    ImageUrl = "/images/pet6.jpg",
                    PetStory = "Kiwi is a colorful Cockatiel with a cheerful personality. He enjoys singing and mimicking sounds.",
                    CreatedDate = DateTime.Now.Date,
                    UserId = 6
                }
            );


            modelBuilder.Entity<Adoption>().HasData(
                new Adoption
                {
                    Id = 1,
                    UserName = "John",
                    PetId = 1,
                    AdoptionDate = DateTime.Now.Date
                },
                new Adoption
                {
                    Id = 2,
                    UserName = "Jane",
                    PetId = 2,
                    AdoptionDate = DateTime.Now.Date
                },
                new Adoption
                {
                    Id = 3,
                    UserName = "Michael",
                    PetId = 3,
                    AdoptionDate = DateTime.Now.Date
                },
                new Adoption
                {
                    Id = 4,
                    UserName = "Emily",
                    PetId = 4,
                    AdoptionDate = DateTime.Now.Date
                },
                new Adoption
                {
                    Id = 5,
                    UserName = "David",
                    PetId = 5,
                    AdoptionDate = DateTime.Now.Date
                },
                new Adoption
                {
                    Id = 6,
                    UserName = "Sarah",
                    PetId = 6,
                    AdoptionDate = DateTime.Now.Date
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Emily", LastName = "Johnson", PhoneNumber = "0611111111" },
                new User { Id = 2, FirstName = "David", LastName = "Smith", PhoneNumber = "0712222222" },
                new User { Id = 3, FirstName = "Sophia", LastName = "Brown", PhoneNumber = "0813333333" },
                new User { Id = 4, FirstName = "Oliver", LastName = "Davis", PhoneNumber = "0614444444" },
                new User { Id = 5, FirstName = "Ava", LastName = "Wilson", PhoneNumber = "0715555555" },
                new User { Id = 6, FirstName = "Lucas", LastName = "Miller", PhoneNumber = "0816666666" }
            );

            modelBuilder.Entity<Donation>().HasData(
                new Donation
                {
                    Id = 1,
                    FullName = "Alice Johnson",
                    PhoneNumber = "0611234567",
                    DonationAmount = 50.00m,
                    DonationDate = DateTime.Now.Date
                },
                new Donation
                {
                    Id = 2,
                    FullName = "Bob Smith",
                    PhoneNumber = "0617654321",
                    DonationAmount = 100.00m,
                    DonationDate = DateTime.Now.Date
                },
                new Donation
                {
                    Id = 3,
                    FullName = "Charlie Brown",
                    PhoneNumber = "0711234567",
                    DonationAmount = 25.00m,
                    DonationDate = DateTime.Now.Date
                },
                new Donation
                {
                    Id = 4,
                    FullName = "David Wilson",
                    PhoneNumber = "0717654321",
                    DonationAmount = 75.00m,
                    DonationDate = DateTime.Now.Date
                },
                new Donation
                {
                    Id = 5,
                    FullName = "Ella Davis",
                    PhoneNumber = "0811234567",
                    DonationAmount = 200.00m,
                    DonationDate = DateTime.Now.Date
                },
                new Donation
                {
                    Id = 6,
                    FullName = "Frank Martin",
                    PhoneNumber = "0817654321",
                    DonationAmount = 30.00m,
                    DonationDate = DateTime.Now.Date
                }
            );
        }
    }
}
