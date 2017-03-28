using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using TrashCollector.Models;



namespace TrashCollector.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }



        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult AccountSummary(ApplicationUser user)
        {
            return View(user);
        }

        public ActionResult EditPickUpSchedule(ApplicationUser user)
        {
            return View(user);
        }

        
    }
}