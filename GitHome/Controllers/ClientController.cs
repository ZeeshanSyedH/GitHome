using System.Web.Mvc;

namespace GitHome.Controllers
{
    public class ClientController : Controller
    {
        // GET: Clients
        public ActionResult Create()
        {
            return View();
        }
    }
}