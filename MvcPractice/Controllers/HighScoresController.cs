using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//bring in the objects
using MvcPractice.Models;

namespace MvcPractice.Controllers
{
    public class HighScoresController : Controller
    {
        //
        // GET: /HighScores/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GuessThatNumber()
        {
            //set up a connection to the database
            Models.HighScoresEntities db = new Models.HighScoresEntities();
            //pass the list of high scores for GTN to the view
            return View(db.HighScores.Where(x=> x.Game == "Guess That Number").OrderBy(x=> x.Score));
        }

        public ActionResult Battleship()
        {
            //set up a connection to the dtabase
            Models.HighScoresEntities db = new Models.HighScoresEntities();
            //pass th list of high scores for GTN to the view
            return View(db.HighScores.Where(x => x.Game == "Battleship").OrderBy(x => x.Score));
        }

        public ActionResult DemonSlayerSimulator1()
        {
            //set up a connection to the dtabase
            Models.HighScoresEntities db = new Models.HighScoresEntities();
            //pass th list of high scores for GTN to the view
            return View(db.HighScores.Where(x => x.Game == "DemonSlayerSimulator1").OrderBy(x => x.Score));
        }

        public ActionResult DemonSlayerSimulator2()
        {
            //set up a connection to the dtabase
            Models.HighScoresEntities db = new Models.HighScoresEntities();
            //pass th list of high scores for GTN to the view
            return View(db.HighScores.Where(x => x.Game == "DemonSlayerSimulator2").OrderBy(x => x.Score));
        }

        public ActionResult Hangman()
        {
            //set up a connection to the dtabase
            Models.HighScoresEntities db = new Models.HighScoresEntities();
            //pass th list of high scores for GTN to the view
            return View(db.HighScores.Where(x => x.Game == "Hangman").OrderBy(x => x.Score));
        }

        public ActionResult TriviaGame()
        {
            //set up a connection to the dtabase
            Models.HighScoresEntities db = new Models.HighScoresEntities();
            //pass th list of high scores for GTN to the view
            return View(db.HighScores.Where(x => x.Game == "TriviaGame").OrderBy(x => x.Score));
        }
    }
}
