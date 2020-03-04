using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accumulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define Variables
            // If it doesnt run add a double for a huge number
            int sum = 0;
            double multiplication = 1;

            // Process -- add up all numbers from 1 - 100 and multiple those as well
            // Add a counter if your adding numbers and incrementing!!
            //   inital point,     Up to 100,      increment
            for (int counter = 1; counter <= 100; counter++)
            {
                sum += counter;
                multiplication *= counter;
            }

            // Output
            Console.WriteLine($"{sum.ToString("n0")}");
            Console.WriteLine($"{multiplication.ToString("n0")}");
            Console.ReadKey();

        }
    }
}
