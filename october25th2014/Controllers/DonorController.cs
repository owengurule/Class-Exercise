using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace october25th2014.Controllers
{
    public class BloodBankController : Controller
    {
        //make a connection to the database
        Models.BloodBankEntities db = new Models.BloodBankEntities();
        
        //
        // GET: /BloodBank/

        public ActionResult Index()
        {
            return View(db.BloodBanks);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View.(db.BloodBanks.Find(id));
        }

    }
}
