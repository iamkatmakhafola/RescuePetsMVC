using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace u21503193_HW02.VIewModels
{
    public class PostPetVM
    {
        // User details

        public int UserId { get; set; }

        [Display(Name = "Full Name")]
        public string SelectedUserFullName { get; set; }

        [Display(Name = "Phone Number")]
        public string SelectedUserPhoneNumber { get; set; }

        // Pet details
        [Required(ErrorMessage = "Pet name is required.")]
        [Display(Name = "Pet Name")]
        public string PetName { get; set; }

        [Required(ErrorMessage = "Pet type is required.")]
        [Display(Name = "Pet Type")]
        public string SelectedPetType { get; set; }

        [Required(ErrorMessage = "Pet breed is required.")]
        [Display(Name = "Pet Breed")]
        public string SelectedPetBreed { get; set; }

        [Required(ErrorMessage = "Pet location is required.")]
        [Display(Name = "Pet Location")]
        public string SelectedPetLocation { get; set; }

        [Required(ErrorMessage = "Pet age is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Age must be a positive number.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Pet weight is required.")]
        [Range(0.1, double.MaxValue, ErrorMessage = "Weight must be greater than 0.")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Pet gender is required.")]
        [Display(Name = "Pet Gender")]
        public string SelectedPetGender { get; set; }

        [Required(ErrorMessage = "Please upload an image of the pet.")]
        [Display(Name = "Pet Image")]
        public IFormFile PetImage { get; set; }

        // Dropdown data
        public List<SelectListItem> UserFullNames { get; set; }
        public List<SelectListItem> UserPhoneNumbers { get; set; }
        public List<SelectListItem> PetTypes { get; set; }
        public List<SelectListItem> PetBreeds { get; set; }
        public List<SelectListItem> PetLocations { get; set; }
        public List<SelectListItem> PetGenders { get; set; }

        public PostPetVM()
        {
            // Initialize the UserFullNames property.
            UserFullNames = new List<SelectListItem>();
        }
    }
}
