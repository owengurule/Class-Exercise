using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPractice.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.ContactForm());
        }

        [HttpPost]
        public ActionResult Index(Models.ContactForm contactForm)
        {
            //create a connection to the database
            Models.ContactFormsEntities db = new Models.ContactFormsEntities();
            //add our contact info to the database.
            db.ContactForms.Add(contactForm);
            //save the changes
            db.SaveChanges();
            //kickk the user to the thankyou page
            return RedirectToAction("ThankYou", "Contact");
        }

        public ActionResult ThankYou()
        {
            return View();
        }

    }
}
