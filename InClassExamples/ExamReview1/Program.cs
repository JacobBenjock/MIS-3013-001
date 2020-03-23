using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamReview1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define Variables
            double moneySavedPerWeek = 0;
            double interestRate = 0.0;
            int totalYearsWantingToSave = 0;
            double totalAmountSaved = 0.0;
            int numMonths = 1; // Keep track of which month of the year we are in
            int numYears = 1;
            

            // Ask the user for input
            Console.WriteLine("How much money will you save per week?");
            moneySavedPerWeek = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your interest rate per month?");
            interestRate = Convert.ToDouble(Console.ReadLine()) / 100; // Divide a rate by 100!

            Console.WriteLine("How many years would you like to save for?");
            totalYearsWantingToSave = Convert.ToInt32(Console.ReadLine());


            // Process--how much will they save after each month
            for (int month = 1; month <= totalYearsWantingToSave * 12; month++)
            {
                 totalAmountSaved += moneySavedPerWeek * 4;
                totalAmountSaved += totalAmountSaved * interestRate;

                string monthName = month.ToString("N0");

                if (numMonths == 1)
                {
                    monthName = "January";
                }
                else if (numMonths == 2)
                {
                    monthName = "February";
                }
                else if (numMonths == 3)
                {
                    monthName = "March";
                }
                else if (numMonths == 4)
                {
                    monthName = "April";
                }
                else if (numMonths == 5)
                {
                    monthName = "May";
                }
                else if (numMonths == 6)
                {
                    monthName = "June";
                }
                else if (numMonths == 7)
                {
                    monthName = "July";
                }
                else if (numMonths == 8)
                {
                    monthName = "August";
                }
                else if (numMonths == 9)
                {
                    monthName = "September";
                }
                else if (numMonths == 10)
                {
                    monthName = "October";
                }
                else if (numMonths == 11)
                {
                    monthName = "November";
                }
                else
                {
                    monthName = "December";
                }

                Console.WriteLine($"{monthName} @ year {numYears.ToString("N0")} : {totalAmountSaved.ToString("C2")}");

                numMonths++;

                if (month % 12 == 0)
                {
                    numYears++;
                    numMonths = 1;
                }
                

            }

            // Output to user-- total amount saved each month and each year in the output
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
