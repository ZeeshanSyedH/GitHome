using GitHome.Models;
using GitHome.ViewModal;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;

namespace GitHome.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create(ClientFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", viewModel);
            }

            var Client = new Client(User.Identity.GetUserId(),
                                    viewModel.FirstName,
                                    viewModel.LastName,
                                    viewModel.Email,
                                    viewModel.PhoneNumber);

            _context.Clients.Add(Client);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


    }
}