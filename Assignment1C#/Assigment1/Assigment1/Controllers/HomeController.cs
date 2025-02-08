using System.Diagnostics;
using Assigment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Assigment1.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.Include(c => c.Category).OrderBy(c => c.FirstName).ToList();
            return View(contacts);
        }

    }
}
