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
using System.Collections;
using System.Collections.Generic;

namespace TrashCollector.Controllers
{
    public class CollectorController : Controller
    {

        private ApplicationDbContext _context;
        // GET: Collector

        public CollectorController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Account(ApplicationUser user, CustomersTodayViewModel customerViewModel)
        {
            
            DateTime today = new DateTime();
            today = DateTime.Today;

            
            foreach (ApplicationUser item in _context.Users)
            {
                if (item.pickUpSchedule != null)
                {
                    if //zip codes match & not the same person
                    (((item.zipCode == user.zipCode) && (item.Id != user.Id)) &&
                    //weekly pickup day is today or special pickup today
                    ((item.pickUpSchedule.weeklyPickUpDay == today.Day) ||
                      (item.pickUpSchedule.specialPickUpDate == today.Date)) &&
                    // today isn't during customer's requested break from collections
                    (!(item.pickUpSchedule.noPickUpsStart <= today.Date &&
                    item.pickUpSchedule.noPickUpsEnd >= today.Date)))
                    {
                        customerViewModel.customersToday.Add(item);
                    }
                }
                
            }
            customerViewModel.user = user;

            return View(customerViewModel);
        }
    }
}