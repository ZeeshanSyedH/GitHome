using GitHome.Models;
using System.Linq;
using System.Web.Mvc;

namespace GitHome.Controllers
{
    public class AgentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AgentController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Clients()
        {
            var agentClients = _context.Clients
                           //.Where(z => z.AgentId == Convert.ToInt32(User.Identity.GetUserId()))
                           .ToList();

            return View(agentClients);
        }

        [Authorize]
        public ActionResult AddClient(Client viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Client newClient = new Client("2", viewModel.FirstName, viewModel.LastName, viewModel.Email, viewModel.PhoneNumber);

            _context.Clients.Add(newClient);
            _context.SaveChanges();

            return RedirectToAction("Clients", "Agent");
        }


    }
}