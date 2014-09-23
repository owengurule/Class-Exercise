using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer2ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayHighScores();

            GameClass myGame = new GameClass();
            myGame.Play();
            Console.ReadKey();

        }
        static void AddHighScore(int playerScore)
        {
            Console.WriteLine("Your Name:");
            string playerName = Console.ReadLine();
            //gateway to database
            OwenEntities db = new OwenEntities();
            //new high score
            HighScore newHighScore = new HighScore();
            //show date created
            newHighScore.DateCreated = DateTime.Now;
            newHighScore.Game = "DragonSlayer2";
            newHighScore.Name = playerName;
            newHighScore.Score = playerScore;

            //add to database
            db.HighScores.Add(newHighScore);
            //save changes
            db.SaveChanges();



        }

        static void DisplayHighScores()
        {
            Console.Clear();
            Console.WriteLine("DragonSlayer2");
            Console.WriteLine("-------------");
            //create a new connection to the database
            OwenEntities db = new OwenEntities();
            //get highscore list
            List<HighScore>highScoreList = db.HighScores.Where(x => x.Game == "DragonSlayer2" ).OrderByDescending(x => x.Score).Take(10).ToList();

            foreach (HighScore highScore in highScoreList) 
            {
                Console.WriteLine("{0}, {1} - {2} on {3}", highScoreList.IndexOf(highScore) + 1, highScore.Name, highScore.Score);
            }
        }
    }
}
