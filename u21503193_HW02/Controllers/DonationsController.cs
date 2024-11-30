using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using u21503193_HW02.Data;
using u21503193_HW02.Models;
using u21503193_HW02.VIewModels;

namespace u21503193_HW02.Controllers
{
    public class DonationsController : Controller
    {
        private readonly DBPetContext _context;

        public DonationsController(DBPetContext context)
        {
            _context = context;
        }

        public IActionResult Donate()
        {
            var fullNames = _context.Donations.ToList();
            var fullNameItems = fullNames.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = d.FullName
            }).ToList();

            var phoneNumber = _context.Donations.ToList();
            var phoneNumberItems = phoneNumber.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = d.PhoneNumber
            }).ToList();

            var viewModel = new DonationVM
            {
                FullNames = fullNameItems,
                PhoneNumbers = phoneNumberItems,
                GoalAmount = 1000
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(DonationVM viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var donation = new Donation
                    {
                        FullName = viewModel.FullName,
                        PhoneNumber = viewModel.PhoneNumber,
                        DonationAmount = viewModel.DonationAmount,
                        DonationDate = DateTime.Now.Date
                    };

                    _context.Donations.Add(donation);
                    _context.SaveChanges();

                    decimal totalAmountRaised = _context.Donations.Sum(d => d.DonationAmount);
                    ViewBag.TotalAmountRaised = totalAmountRaised;

                    ViewBag.SuccessMessage = "Thank you for your donation!";

                    return RedirectToAction("Donate");
                }
            }
            catch (Exception)
            {
                ViewBag.ErrorMessage = "An error occurred while posting the pet. Please try again.";
            }

            return View("Donate", viewModel);
        }


    }
}
