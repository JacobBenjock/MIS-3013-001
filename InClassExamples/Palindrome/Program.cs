using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define Variables
            string userInput, userInputReversed = "";
            int index;

            // User Input
            Console.WriteLine("Please enter a word or phrase");
            userInput = Console.ReadLine();
            index = userInput.Length - 1;

            /* Process
             * Establish that userinputreversed is equal to userinput index
             * Must have an index that reads the input entirely, string.Length - 1 
             * Establish a += with the userinput[index] and increment backwards (index--)
             */ 
            do
            {
                userInputReversed += userInput[index];
                index--;


            } while (index >= 0);

            // Conditional to print out whether or not this word is a palindrome
            if (userInput == userInputReversed)
            {
                Console.WriteLine($"The word {userInput} is a palindrome");
            }
            else
            {
                Console.WriteLine($"The word {userInput} reversed is {userInputReversed}");
            }
            Console.WriteLine(userInputReversed);

            //Output
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
