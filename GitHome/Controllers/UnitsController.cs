using GitHome.Models;
using GitHome.ViewModal;
using System.Collections.Generic;
using System.Data.Entity;
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


            UnitProperties newUnitProperties = new UnitProperties(newAddress,
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


            Unit newProperty = new Unit(1,
                newUnitProperties,
                viewModel.GetDateTime());

            _context.Units.Add(newProperty);
            _context.SaveChanges();

            return RedirectToAction("List", "Units");

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


        [Authorize]
        public ActionResult List()
        {
            var AgentProperties = _context.Units
                .Include(x => x.UnitDetail)
                //.Where(g => g.AgentId == User.Identity.getuserId())
                .ToList();

            return View(AgentProperties);
        }

    }
}