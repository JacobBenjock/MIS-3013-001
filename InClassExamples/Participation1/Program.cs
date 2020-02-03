using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // commands an input from the customer
            Console.WriteLine("Enter Heads or Tails >>");
            string usersGuessAsString = Console.ReadLine();
            int usersGuess;

            // Declare our constant variables
            const int HEADS_VALUE = 0;
            const int TAILS_VALUE = 1;
            // conditional to see what the value of a flip would be
            if (usersGuessAsString == "Heads")
            {

                usersGuess = HEADS_VALUE;
            }
            else
            {
                usersGuess = TAILS_VALUE;
            }
            // generates a random number from the flip
            Random coinFlip = new Random();

            // use the next method on 'rand' and pass in 0,2 to generate a random number that is 0 or 1

            int randomNumber = coinFlip.Next(0, 2);
            // conditional to describe whether or not they guessed correctly

            if (usersGuess == randomNumber)
            {
                Console.WriteLine($"Congrats, {usersGuessAsString} was right");
            }
            else
            { 
                Console.WriteLine("You Lose");
            }
            
            Console.ReadKey();
            
            

            

            
        }
    }
}
