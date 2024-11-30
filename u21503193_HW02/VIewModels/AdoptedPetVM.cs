using Microsoft.AspNetCore.Mvc.Rendering;
using u21503193_HW02.Models;

namespace u21503193_HW02.VIewModels
{
    public class AdoptedPetVM
    {
        public string UserName { get; set; }
        public string PetName { get; set; }

        public string SelectedUserFullName { get; set; }
        public string SelectedUserPhoneNumber { get; set; }
        public Pet Pet { get; set; }

        public List<SelectListItem> UserFullNames { get; set; }
        public List<SelectListItem> UserPhoneNumbers { get; set; }
    }
}
