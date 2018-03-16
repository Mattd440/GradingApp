using System;
using GradingProject.Models;
namespace GradingProject
{
    public class Homework : Assignment
    {
        
        public Homework(Grade grd, string title, Class cl, Student std): base("Homework", grd, title, cl, std)
        {
            
        }
		
	}
}
