using GitHome.Models;
using GitHome.ViewModal;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace GitHome.Controllers
{
    public class UnitsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UnitsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new UnitFormViewModel
            {
                Clients = _context.Clients.ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(UnitFormViewModel viewModel)
        {
            // CURRENT USER
            var UserId = User.Identity.GetUserId();

            // GET CURRENT USERID OF LOGGED IN USER
            var Agent = _context.Users.Single(u => u.Id == UserId);

            // CREATE ADDRESS FROM VIEW

            var Unit = new Unit
            {
                AgentID = Agent,
                AvailableFrom = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                clientID = Convert.ToInt32(viewModel.Client),

                UnitDetailID = new UnitDetails
                {
                    // CREATE ADDRESS
                    AddressID = new Address
                    {
                        civicNumber = Convert.ToInt32(viewModel.Civic),
                        street = viewModel.Street,
                        city = viewModel.City,
                        zipCode = viewModel.ZipCode
                    },

                    // CREATE OTHER ATTIBUTES
                    askingPrice = Convert.ToInt32(viewModel.Price),
                    centralAirConditioning = viewModel.CentralAirCondition,
                    yearBuilt = Convert.ToInt32(viewModel.YearBuilt),
                    numRooms = Convert.ToInt32(viewModel.Rooms),
                    numBathrooms = Convert.ToInt32(viewModel.Bathrooms),
                    numBedrooms = Convert.ToInt32(viewModel.Bedrooms),
                    numGarageDoors = Convert.ToInt32(viewModel.Garages),
                    description = viewModel.Description
                }
            };

            _context.Units.Add(Unit);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");

        }
    }
}