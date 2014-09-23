using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer2ClassProject
{
    class EnemyClass
    {



        //Name of the enemy
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value.ToUpper() ; }
        }

        //create a RNG
        private Random rng = new Random();
        
        //Health of the enemy
        private int _hp;

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        //read only property for IsAlive
        public bool IsAlive
        {
            get { return this.HP > 0; }
        }


        //Constructor
        public EnemyClass(string name, int startingHP)
            //intialize the object
        {
            this.HP = startingHP;
            this.Name = name;
        }
        
        //Do our attack method
        public void Attack(PlayerClass player)
        {
            //80% chance to hit
            if (rng.Next(0, 101) > 2)
            {
                //hit!
                int damage = rng.Next(5, 16);

                //we will hit the player
                player.HP -= damage;

                //write the output to the console.
                Console.WriteLine("{0} hit you for {1} damage!", this.Name, player.Name, damage);
            }
            else
            {
                //miss
                Console.WriteLine("{0} missed {1}", this.Name, player.Name);
            
            }
        }

    }
}
