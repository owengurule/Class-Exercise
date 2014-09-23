using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketExample();

            //Car myCar = new Car("Honda", "Civic");
            //Car myCar2 = new Car();

            //Console.WriteLine(myCar.GetInfo());
            //Console.WriteLine(myCar2.GetInfo());

            //myCar.Honk();


            ////create a new student
            //Student Pat = new Student(10001, "Pat", "McClary");

            ////add a course
            //Pat.Courses.Add(new Course("Proffesional development", "B"));
            //Pat.Courses.Add(new Course("Hockey 101", "B"));
            //Pat.Courses.Add(new Course("Intro to Programming", "B"));
            //Pat.Courses.Add(new Course("Being Bad", "B"));
            //Pat.Courses.Add(new Course("English 102", "A"));

            ////print out all the info about pat
            //Pat.PrintInfo();

            //Student Owen = new Student(10002, "Owen", "Gurugula");

            //Logan.PrintInfo();

            //keep the console open
            Console.ReadKey();
        }
        static void TicketExample()
        {
            //create a new list to hold our tickets
            List<Ticket> ticketList = new List<Ticket>();

            //create a new ticket
            Ticket ticket1 = new Ticket("Nicole", "RSVP form is broken", Priority.Critical);
            //let some time pass
            System.Threading.Thread.Sleep(1000);
            //resolve ticket 1
            ticket1.ResolveTicket();
            //add it to the list
            ticketList.Add(ticket1);

            //add two more tickets
            ticketList.Add(new Ticket("Pat", "Hockey stick is broke", Priority.NonCritical));
            ticketList.Add(new Ticket("Logan", "hes sick today", Priority.HighImportance));

            //print them out to the console, ordered by priority
            Console.WriteLine(string.Join("\n", ticketList.OrderBy(x => x.Priority).Select (x => x.GetTicketInfo())));

            //print out only the unresolved tickets
            Console.WriteLine(string.Join("\n", ticketList.Where(x => x.Resolved).Select(x => x.GetTicketInfo())));



        }
    }
}
