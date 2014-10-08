using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPractice.Controllers
{
    public class AdminController : Controller
    {

        //step 1. Create a connection to our database
        Models.ContactFormsEntities db = new Models.ContactFormsEntities();
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            //list the contents of our contact forms
            return View(db.ContactForms);
        }

        public ActionResult Details(int id)
        {
            return View(db.ContactForms.Find(id));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.ContactForms.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Models.ContactForm contactForm)
        {
        //tell the db context that the contact form needs to be updated
        db.Entry(contactForm).State = System.Data.EntityState.Modified;
        //save changes
        db.SaveChanges();
        //kick the user back to the list
        return RedirectToAction("Index", "Admin");
        }

        public ActionResult Delete(int id)
        {
            return View(db.ContactForms.Find(id));
        }

        public ActionResult DeleteConfirm(int id)
        {
            //get the form to delete from the database
            Models.ContactForm formToDelete = db.ContactForms.Find(id);
            //set form to be deleted
            db.ContactForms.Remove(formToDelete);
            //save changes
            db.SaveChanges();
            //kick user back to list
            return RedirectToAction("Index", "Admin");
        }

    

    }
}
