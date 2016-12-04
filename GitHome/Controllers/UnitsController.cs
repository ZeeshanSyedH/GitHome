using GitHome.Models;
using GitHome.ViewModal;
using System.Linq;
using System.Web.Mvc;

namespace GitHome.Controllers
{
    public class UnitsController : Controller
    {
        private ApplicationDbContext _context;
        public UnitsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Units
        public ActionResult Create()
        {
            var viewModel = new UnitFormViewModel
            {
                Clients = _context.Clients.ToList()
            };

            return View(viewModel);
        }
    }
}