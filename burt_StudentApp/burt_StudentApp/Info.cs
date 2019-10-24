using System;
using System.Collections.Generic;
using System.Text;

namespace burt_StudentApp
{
    class Info
    {
        public void Display(string currentAssignment)
        {
            string barrier = "**********************************";

            Console.WriteLine(barrier + "\n\n");
            Console.WriteLine("Name:\t\tJanelle Burt");
            Console.WriteLine("Course:\t\tITDEV 115-501");
            Console.WriteLine("Instructor:\tJanese Christie");
            Console.WriteLine("Assignment:\t" + currentAssignment);
            Console.WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine("\n\n" + barrier);
        }
    }
}
