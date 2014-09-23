using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer2ClassProject
{
    class PlayerClass
    {


        //enum for attack types
        public enum AttackType
        {
            Sword = 1,
            Magic,
            Heal
        }

        

        private int _hp;

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        //create our RNG
        private Random rng = new Random();


        //player's name
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        

        //read only property for IsAlive
        public bool IsAlive
        {
            get { return this.HP > 0; }
        }

        //Constructor
        public PlayerClass (string name, int startingHP)
        {
            this.Name = name; this.HP = startingHP;
        }

        //create a new function to choose attack
        private AttackType ChooseAttack()
        {
            Console.WriteLine(@"
            Choose Attack:
            1.Sword
            2.Magic
            3.Heal");
            //get input from the user
            int input = int.Parse(Console.ReadLine());
            //return the correct AttackType
            return (AttackType)input;
        }

        public void Attack(EnemyClass enemy)
        {

            int damage;
            //use a switch statement to perform the attack
            switch (ChooseAttack())
            {
                case AttackType.Sword:
                    //70% chance to hit
                    if (rng.Next(0, 101) > 3)
                    {
                        //hit! deal 15-30 damage
                        damage = rng.Next(15, 31);
                        //deal the damage to the enemy
                        enemy.HP -= damage;
                        //write the output to the user
                        Console.WriteLine("{0} deals {1} damage to {2}", this.Name, damage, enemy.Name);
                    }
                    else
                    {
                        //missed
                        Console.WriteLine("{0} missed {1} with the {2}", this.Name, enemy.Name);
                    }

                    break;
                case AttackType.Magic:
                    //magic always deals 5-15 damage
                    damage = rng.Next(1, 16);
                    //deal damage to the enemy
                    enemy.HP -= damage;

                    Console.WriteLine("{0} deals {1} damage to {2}", this.Name, damage, enemy.Name);

                    
                    
                    break;
                case AttackType.Heal:
                    //always heal 10-20
                    
                    break;
                default:
                    break;
            }
        }


        
    }
}
