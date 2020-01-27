// Jacob Benjock
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputFormattingConvertingAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite number: ");
            int favNumber = Convert.ToInt32(Console.ReadLine());

            int favNumberTimes10 = 10 * favNumber;

            //concatenate a string called message

            string message = firstName + " you have a favorite number of " + favNumber.ToString("N3") + " and if you multiply that by 10 you get " + favNumberTimes10.ToString("C3");

            if(favNumber == 7 || favNumber == 3)
            {
                Console.WriteLine("How original are you");
            }
            else if(favNumber == 14)
            {
                Console.WriteLine("You have no luck");
            }
            else
            {
                Console.WriteLine(message);
            }

            if (favNumber % 2 == 0)
            {
                Console.WriteLine("your number is even");
            }
            else
            {
                Console.WriteLine("your number is odd");
            }


        

            Console.ReadKey();
        }
    }
}
