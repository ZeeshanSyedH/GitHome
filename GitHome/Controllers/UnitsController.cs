using GitHome.Models;
using GitHome.ViewModal;
using System.Collections.Generic;
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
            var viewModel = new UnitFormViewModel()
            {
                Clients = GetClientList()
            };
            //viewModel.Clients = new List<SelectListItem>()
            //{
            //    new SelectListItem { Value = "1", Text = "Test 1" },
            //    new SelectListItem { Value = "2", Text = "Test 2" },
            //    new SelectListItem { Value = "3", Text = "Test 3" }
            //};

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UnitFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Clients = GetClientList();

                return View("Create", viewModel);
            }

            Address newAddress = new Address(viewModel.Civic,
                                             viewModel.Street,
                                             viewModel.City,
                                             viewModel.ZipCode);

            _context.Addresses.Add(newAddress);
            _context.SaveChanges();

            UnitProperties newUnitProperties = new UnitProperties(newAddress.addressID,
                                                                  true,
                                                                  viewModel.YearBuilt,
                                                                  viewModel.Price,
                                                                  viewModel.Title,
                                                                  viewModel.Description,
                                                                  viewModel.Rooms,
                                                                  viewModel.Bedrooms,
                                                                  viewModel.Bathrooms,
                                                                  viewModel.Garages,
                                                                  viewModel.CentralAirCondition);

            _context.Properties.Add(newUnitProperties);
            _context.SaveChanges();


            Unit newProperty = new Unit(1,
                newUnitProperties.unitDetailID,
                viewModel.GetDateTime());

            _context.Units.Add(newProperty);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");

        }

        private IEnumerable<SelectListItem> GetClientList()
        {
            return _context
                    .Clients
                    .Select(c => new SelectListItem
                    {
                        Text = c.clientID + " " + c.FirstName,
                        Value = c.clientID.ToString()
                    })
                    .ToList();
        }
    }
}