using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer2ClassProject
{
    class GameClass
    {

        public PlayerClass Player { get; set; }
        public EnemyClass Enemy { get; set; }


        //Constructor
        public GameClass()
        {
            this.Player = new PlayerClass("The mighty Owen", 100);
            this.Enemy = new EnemyClass("The mightier Dustin", 200);
        }


        //Methods
        private void DisplayInfo()
        {
            //displays current hp totals for player and emey
            Console.WriteLine("{0} {1}HP vs {2} {3}HP", Player.Name, Player.HP, Enemy.Name, Enemy.HP);
        }

        public void Play()
        {
            //playing while IsAlive is true, or (bot are alive)
            while (Player.IsAlive && Enemy.IsAlive)
            {
                DisplayInfo(); // show current HP
                Player.Attack(Enemy); // Player attacks enemy
                Enemy.Attack(Player); // Enemy attacks player
            }
            //someone die
            if (!Player.IsAlive)
            {
                Console.WriteLine("{0} hath beens slain", this.Player.Name);
            }
            else
            {
                Console.WriteLine("{0} hath been defeated", this.Enemy.Name);
            }
            }


    }
}
