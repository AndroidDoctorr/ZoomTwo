using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrokenApp.Models;
using BrokenApp.Services;

namespace BrokenApp.WebMVC.Controllers
{
    public class AttendeeController : Controller
    {
        // GET: Attendee
        public ActionResult Index()
        {
            return View(CreateAttendeeService().GetAttendeeList());
        }

        public ActionResult Create()
        {
            ViewBag.Title = "New Attendee";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AttendeeCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            if (CreateAttendeeService().CreateAttendee(model))
            {
                TempData["SaveResult"] = "Attendee added";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Something went wrong - could not create a meeting");
            return View(model);
        }

        private AttendeeService CreateAttendeeService()
        {
            return new AttendeeService();
        }
    }
}