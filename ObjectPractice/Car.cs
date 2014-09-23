using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    public class Car
    {
        //Declare properties and variables
        private string _make;
        // only underline before the property if its a privat string.
        //variable for the 
        //Declare the Make property

        
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                //you can add ToUpper after value to make the input of Make all UpperCase
                _make = value;
            }
        }
        //shorthand version of a property
        //code snippet: prop <tab><tab>
        public string Model { get; set; }

        //step 2 Declare Constructor
        public Car(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public Car()
        {
            this.Model = "undefined";
            this.Make = "undefined";
        }
        //step 3
        public void Honk()
        {
            Console.WriteLine("Beep beep");
            Console.Beep();
            Console.Beep();
        }
        public string GetInfo()
        {
            //returns a string with information about the car
            return this.Make + " " + this.Model;
        }
    }
}
