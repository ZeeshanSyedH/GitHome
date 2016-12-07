using GitHome.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace GitHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();

        }

        public ActionResult Index()
        {
            var propertiesForSale = _context.Units
                .Include(x => x.UnitDetail)
                .Where(g => g.UnitDetail.forSale)
                .ToList();

            return View(propertiesForSale);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}