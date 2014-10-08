using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        Models.BlogEntities db = new Models.BlogEntities();
        [HttpGet]
        public ActionResult Index()
        {

            return View(db.Posts.OrderByDescending(x => x.DateCreate));
        }

        public ActionResult AddComment(Models.Comment commentToAdd)
        {
            //make sure the comment is fully filled out
            commentToAdd.DateCreated = DateTime.Now;
            
            db.Comments.Add(commentToAdd);
            //add the comment to the database
            db.Comments.Add(commentToAdd);
            db.SaveChanges();

                //for now until we ajax it, we will kick the user back to the index
            return RedirectToAction("Index", "Home");

            
        }

    }
}
