using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using u21503193_HW02.Data;
using u21503193_HW02.Models;
using u21503193_HW02.VIewModels;

namespace u21503193_HW02.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBPetContext _context;

        public HomeController(DBPetContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                int adoptedPetsCount = _context.Adoptions.Count();

                List<AdoptedPetVM> adoptedPets = _context.Adoptions
                    .Include(a => a.Pet)
                    .Select(a => new AdoptedPetVM
                    {
                        UserName = a.UserName,
                        PetName = a.Pet.Name
                    })
                    .ToList();

                var viewModel = new HomeVM
                {
                    AdoptedPetCount = adoptedPetsCount,
                    AdoptedPets = adoptedPets
                };

                return View(viewModel);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                ViewBag.Error = message;
            }
            return View();

        }



    }
}