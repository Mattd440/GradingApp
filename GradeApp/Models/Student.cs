using System;
namespace GradingProject.Models
{
    public class Student
    {
        public static int SId = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }

        public Student(string first, string last, string major)
        {
            Id = SId;
            FirstName = first;
            LastName = last;
            Major = major;

            SId++;
        }

        // should add student to database
        public static Student AddStudent()
        {
            Console.WriteLine("Enter Student First Name");
            string first = Console.ReadLine();
            Console.WriteLine("Enter Student Last Name");
            string last = Console.ReadLine();
            Console.WriteLine("Enter Student Major");
            string major = Console.ReadLine();

            Student student = new Student(first, last, major);

            return student;
            // add to database here
        }

        // checks if the student id entered is valid
        public static bool StudentExists(int id)
        {
            if(id <= SId)
            {
                return true;
            }else{
                return false;
            }
        }
    }
}
