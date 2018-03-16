using System;
using GradingProject.Models;
namespace GradingProject
{
    public abstract class Assignment
    {
        public static int AId = 0;
        int Id { get; set; }
        string Type { get; set; }
        Grade AssignmentGrade { get; set; }
        string Title { get; set; }
        Class AssignmentClass { get; set; }
        Student Student { get; set; }

        public Assignment(string type, Grade grade, string title, Class cl, Student std)
        {
            Id = AId;
            Type = type;
            AssignmentGrade = grade;
            Title = title;
            AssignmentClass = cl;
            Student = std;

            AId++;
        }

        public static Assignment AddAssignment(Student std)
        {
            bool invalidType = true;
            bool invalidClass = true;
            bool invalidGrade = true;
            int type = 1;
            string asgType = "" ;
            int cls;
            Grade grade = Grade.None;
            int grd;
            string title;
            Class classType = Class.None;

            while (invalidType)
            {
                Console.WriteLine("Enter 1 to enter A new Homework Assignment ");
                Console.WriteLine("Enter 2 to enter A new Test Assignment");
                try
                {
                    type = int.Parse(Console.ReadLine());
                    if (type == 1 || type == 2)
                    {
                        invalidType = false;
                        if (type == 1)
                        {
                            asgType = "Homework";
                        }

                        if (type == 2)
                        {
                            asgType = "Test";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry");
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Enter Assignment Title");
            title = Console.ReadLine();

            while (invalidClass)
            {
                Console.WriteLine("Enter 1 To Enter A Math Assignment ");
                Console.WriteLine("Enter 2 To Enter A English Assignment ");
                Console.WriteLine("Enter 3 To Enter A Science Assignment ");
                Console.WriteLine("Enter 4 To Enter A Computer Science Assignment ");
                Console.WriteLine("Enter 5 To Enter A History Assignment ");
                try
                {
                    cls = int.Parse(Console.ReadLine());

                    // controls whether the loops continues or stops
                    if (cls > 5 || cls < 1)
                    {
                        Console.WriteLine("Invalid Entry ");
                        continue;
                    }
                    else
                    {
                        invalidClass = false;
                    }

                    switch (cls)
                    {
                        case 1:
                            classType = Class.Math;
                            break;
                        case 2:
                            classType = Class.English;
                            break;
                        case 3:
                            classType = Class.Science;
                            break;
                        case 4:
                            classType = Class.ComputerScience;
                            break;
                        case 5:
                            classType = Class.History;
                            break;
                        default:
                            invalidClass = true;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (invalidGrade)
            {
                Console.WriteLine("Enter 1 to Give Grade of 'A' ");
                Console.WriteLine("Enter 2 to Give Grade of 'B' ");
                Console.WriteLine("Enter 3 to Give Grade of 'C' ");
                Console.WriteLine("Enter 4 to Give Grade of 'D' ");
                Console.WriteLine("Enter 5 to Give Grade of 'F' ");
                try
                {
                    grd = int.Parse(Console.ReadLine());

                    if (grd > 5 || grd < 1)
                    {
                        Console.WriteLine("Invalid Entry");
                        continue;

                    }
                    else
                    {
                        invalidGrade = false;
                    }


                    switch (grd)
                    {
                        case 1:
                            grade = Grade.A;
                            break;
                        case 2:
                            grade = Grade.B;
                            break;
                        case 3:
                            grade = Grade.C;
                            break;
                        case 4:
                            grade = Grade.D;
                            break;
                        case 5:
                            grade = Grade.F;
                            break;
                        default:
                            grade = Grade.F;
                            invalidClass = true;
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            if (type == 1)
            {
                return new Homework(grade, title, classType, std);
            }
            else
            {
                return new Test(grade, title, classType, std);
            }
        }


        // Grade.tostring may cause error
        public override string ToString()
        {
            return String.Format("Student: {0}, {1} , Title: {2} , Class: {3} , Grade: {4}",
                                 this.Student.LastName, this.Student.FirstName, this.Title, this.AssignmentClass.ToString(), this.AssignmentGrade.ToString());
        }
    }
}

