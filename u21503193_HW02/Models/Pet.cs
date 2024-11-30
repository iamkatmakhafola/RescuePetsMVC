using System;
using System.ComponentModel.DataAnnotations;

namespace u21503193_HW02.Models
{
    public class Pet
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Breed { get; set; }

        public string Location { get; set; }

        public int Age { get; set; }

        public decimal Weight { get; set; }

        public string Gender { get; set; }

        public string Status { get; set; }

        public string PetStory { get; set; }

        public string ImageUrl { get; set; }

        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
