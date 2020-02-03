using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to count to?");
            int threshold = Convert.ToInt32(Console.ReadLine());

            // for loop
            for (int i = 1; i <= threshold; i++)
            {
                Console.WriteLine(i);
            }
            double sum = 0; // this is an accumulator
            string answer;
            

            // do while loop
            do
            {
                Console.WriteLine("Please give us a number to add");
                int number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number;

                Console.WriteLine("Do you have another # to add? (y/n)");
                answer = Console.ReadLine();



            } while (answer.ToLower() == "y");
            Console.WriteLine($"Your summation of values is {sum.ToString("N2")}");

            Console.ReadKey();
            
            
        }
        
    }
}
