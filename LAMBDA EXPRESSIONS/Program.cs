using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA_EXPRESSIONS
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare a list of test strings
            List<string> myList = new List<string>() {"tyler", "kiwi", "strawberry", "boisonberry", "blueberry", "mango", "pineapple", "apple", "blackberry"
            };
            OrderByExample(myList);


            List<string> berryList = new List<string>() {"tyler", "kiwi", "strawberry", "boisonberry", "blueberry", "mango", "pineapple", "apple", "blackberry"
            };
            WhereExample(berryList);
            DistinctExample();

                        List<string> sorted = new List<string>() {"tyler", "kiwi", "strawberry", "boisonberry", "blueberry", "mango", "pineapple", "apple", "blackberry"
            };
            SkipAndTakeExample(sorted);
        }


        static void OrderByExample(IEnumerable<string> list)
        {
            //orrder the list by length and print them out to the console
            // order by sorts of length of the word, then by sorts alphabetically
            List<string> orderedList = list.OrderBy(x => x.Length).ThenBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", orderedList));
        }

        static void WhereExample(IEnumerable<string> list)
        {
            //print to the console all items in the list
            //that contain the word "berry"
            List<string> berryList = list.Where(x => x.Contains("berry")).ToList();
            Console.WriteLine(string.Join(", ", berryList));
        }

        static void DistinctExample()
        {
            //declar a new list of intergers with a bunch of duplicate values
            List<int> intList = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 5, 5, 7, 7, 8 };
            Console.WriteLine(string.Join(", ", intList.Distinct()));
        }

        static void FirstAndLastExample(IEnumerable<string> list)
        {
            //we are going to sort the list alphabetically and print the first and last items to the console.
            List<string> sorted = list.OrderBy(x => x).ToList();

           
        }
        static void SkipAndTakeExample(IEnumerable<string> list)
        {
            //we want to print ur 3rd item from our list ordered length
            List<string> sorted = list.OrderBy(x => x.Length).ToList();
            //skip two items print the third
            Console.WriteLine(list.Skip(2).Take(1).First());
        }
    

    
    }
}
