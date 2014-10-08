using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace october25th2014.Controllers
{
    public class Donor : Controller
    {
        //make a connection to the database
        Models.BloodBankEntities db = new Models.BloodBankEntities();
        
        //
        // GET: /BloodBank/

        public ActionResult Index()
        {
            return View(db.Donors);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.Donors.Find(id));
        }

        public ActionResult Details(int id)
        {
            return View(db.Donors.Find(id));
        }
    }
}
