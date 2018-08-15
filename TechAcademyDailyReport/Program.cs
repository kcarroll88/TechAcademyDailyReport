using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseType = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            int numOfPage = Convert.ToInt32(pageNum);
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\"");
            string needHelp = Console.ReadLine();
            string helpStatus = Convert.ToString(needHelp);
            Console.WriteLine("Are there any positive experiences you'd like to provide? Please be specific.");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int studyingHours = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
            
        }
    }
}
