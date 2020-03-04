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
                Console.WriteLine($"{month.ToString("N0")} : {totalAmountSaved.ToString("C2")}");

            }

            // Output to user-- total amount saved each month and each year in the output
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
