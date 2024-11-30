using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using u21503193_HW02.Data;
using u21503193_HW02.Models;
using u21503193_HW02.VIewModels;

namespace u21503193_HW02.Controllers
{
    public class PetsController : Controller
    {
        private readonly DBPetContext _context;

        public PetsController(DBPetContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var types = _context.Pets.Select(p => p.Type).Distinct().ToList();
            var breeds = _context.Pets.Select(p => p.Breed).Distinct().ToList();
            var locations = _context.Pets.Select(p => p.Location).Distinct().ToList();

            var Pets = _context.Pets
                .Select(p => new PetVM
                {
                    Id = p.Id,
                    Name = p.Name,
                    Location = p.Location,
                    Age = p.Age,
                    Gender = p.Gender,
                    Weight = p.Weight,
                    Status = p.Status,
                    PetStory = p.PetStory,
                    ImageUrl = p.ImageUrl,
                    UserName = p.User.FirstName + " " + p.User.LastName,
                    CreatedDate = p.CreatedDate
                })
                .ToList();

            var viewModel = new PetsFilterVM
            {
                Pets = Pets,
                Types = types,
                Breeds = breeds,
                Locations = locations
            };

            return View(viewModel);
        }

        [Route("Pets/AdoptPet/{id}")]
        public IActionResult AdoptPet(int id)
        {
            var selectedPet = _context.Pets.SingleOrDefault(p => p.Id == id);

            var users = _context.Users.ToList();
            var fullNameItems = users.Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = $"{u.FirstName} {u.LastName}"
            }).ToList();

            var phoneNumber = _context.Users.ToList();
            var phoneNumberItems = phoneNumber.Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.PhoneNumber
            }).ToList();

            var viewModel = new AdoptedPetVM
            {
                Pet = selectedPet,
                UserFullNames = fullNameItems,
                UserPhoneNumbers = phoneNumberItems
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AdoptPet(int id, AdoptedPetVM viewModel)
        {
            if (ModelState.IsValid)
            {
                var selectedPet = _context.Pets.SingleOrDefault(p => p.Id == id);

                if (selectedPet != null)
                {
                    var user = _context.Users.SingleOrDefault(u =>
                        $"{u.FirstName} {u.LastName}" == viewModel.SelectedUserFullName);

                    if (user != null)
                    {
                        var adoption = new Adoption
                        {
                            PetId = selectedPet.Id,
                            UseId = user.Id,
                            AdoptionDate = DateTime.Now
                        };

                        _context.Adoptions.Add(adoption);
                        _context.SaveChanges();

                        return RedirectToAction("Index");
                    }
                }
            }

            return View(viewModel);
        }

        public IActionResult PostPet()
        {
            var users = _context.Users.ToList();
            var fullNameItems = users.Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = $"{u.FirstName} {u.LastName}"
            }).ToList();

            var phoneNumber = _context.Users.ToList();
            var phoneNumberItems = phoneNumber.Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.PhoneNumber
            }).ToList();

            var petTypes = _context.Pets.Select(pt => pt.Type)
            .Distinct()
            .ToList();

            var petTypeItems = petTypes.Select(type => new SelectListItem
            {
                Value = type,
                Text = type
            }).ToList();

            var viewModel = new PostPetVM
            {
                UserFullNames = fullNameItems,
                UserPhoneNumbers = phoneNumberItems,
                PetTypes = petTypeItems
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostPet(PostPetVM viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var pet = new Pet
                    {
                        Name = viewModel.PetName,
                        Type = viewModel.SelectedPetType,
                        Breed = viewModel.SelectedPetBreed,
                        Location = viewModel.SelectedPetLocation,
                        Age = viewModel.Age,
                        Weight = (decimal)viewModel.Weight,
                        Gender = viewModel.SelectedPetGender,
                        Status = "Available"
                    };

                    var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == viewModel.UserId);
                    if (user != null)
                    {
                        pet.User = user;

                        _context.Pets.Add(pet);
                        await _context.SaveChangesAsync();

                        ViewBag.SuccessMessage = "Pet posted successfully!";
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = "An error occurred while posting the pet. Please try again.";
                }
                
            }
            return View("PostPet", viewModel);
        }

    }
}
