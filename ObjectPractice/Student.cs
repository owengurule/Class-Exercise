using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Student
    {
        //step 1: Declare properties
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }

        //step 2. Constructor
        public Student(int studentID, string firstName, string lastName)
        {
                    this.StudentID = studentID;
                    this.FirstName = firstName;
                    this.LastName = lastName;

            //make sure to intialize the Course List
                    this.Courses = new List<Course>();
        }


        //step 3. Methos and Functions
        public void PrintInfo()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
            Console.WriteLine("Student ID: {0}", this.StudentID);
            //write out each course and grade
            Console.WriteLine(string.Join("\n", this.Courses.Select(x => x.GetCourseInfo())));


            //write out total GPA
            Console.WriteLine("GPA: {0}", this.Courses.Average(x => x.GradePoints));
        }

    }
}
