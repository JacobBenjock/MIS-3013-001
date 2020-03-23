using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthDays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define Variables
            string monthLookup;
            int daysInMonth = 0;
            string isLeapYear;
            // Input
            Console.WriteLine("What month would you like to lookup (e.g. February)");
            monthLookup = Console.ReadLine();

            // Process
            if (monthLookup == "January" || monthLookup == "March" || monthLookup == "July" || monthLookup == "August")
            {
                daysInMonth = 31;
            }
            else if (monthLookup == "February")
            {
                Console.WriteLine("Is it a leap year?");
                isLeapYear = Console.ReadLine();

                if (isLeapYear.ToUpper() == "YES")
                {
                    daysInMonth = 29;
                }
                else
                {
                    daysInMonth = 26;
                }
            }
            else if (monthLookup == "May" || monthLookup == "June")
            {
                daysInMonth = 30;
            } // PRO TIP: Don't necessarily need else

            //Output
            Console.WriteLine($"The number of days in the month {monthLookup} is {daysInMonth}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}
