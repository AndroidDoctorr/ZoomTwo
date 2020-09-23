using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrokenApp.Models;
using BrokenApp.Services;

namespace BrokenApp.WebMVC.Controllers
{
    public class OrganizationController : Controller
    {
        // GET: Organization
        public ActionResult Index()
        {
            return View(new OrganizationService().GetOrganizationList());
        }

        public ActionResult Create()
        {
            ViewBag.Title = "New Organization";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrganizationCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            if (new OrganizationService().CreateOrganization(model))
            {
                TempData["SaveResult"] = "Organization established";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Something went wrong - could not create an organization");
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var Organization = new OrganizationService().GetOrganizationDetailsById(id);
            return View(Organization);
        }

        public ActionResult Edit(int id)
        {
            var Organization = new OrganizationService().GetOrganizationDetailsById(id);
            return View(new OrganizationEdit
            {
                OrganizationId = Organization.OrganizationId,
                Name = Organization.Name
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, OrganizationEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.OrganizationId != id)
            {
                ModelState.AddModelError("", "Id mismatch");
                return View(model);
            }

            if (new OrganizationService().UpdateOrganization(model))
            {
                TempData["SaveResult"] = "Organization updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Something went wrong - could not edit organization");
            return View(model);
        }
    }
}