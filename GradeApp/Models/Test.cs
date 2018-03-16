using System;
namespace GradingProject.Models
{
    public class Test: Assignment
    {
        public Test(Grade grd, string title, Class cl, Student std) : base("Test", grd, title, cl, std)
        {
        }
    }
}
