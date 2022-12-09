using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Controllers
{
    [AllowAnonymous]
    [Route("/")]
    public class HomeController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(EntityLayer.Concrete.Contact contact)
        {
            string errorMessage = "";
            ContactValidator cv = new ContactValidator();
            ValidationResult result = cv.Validate(contact);
            if (result.IsValid)
            {
                contact.ContactDate = DateTime.Parse(DateTime.Now.ToString());
                cm.TAdd(contact);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (ValidationFailure failer in result.Errors)
                {
                    ModelState.AddModelError(failer.PropertyName, failer.ErrorMessage);
                    errorMessage += failer.ErrorMessage + "\\n";
                }
            }
            ViewBag.Errors = errorMessage;
            return View();
        }
    }
}
