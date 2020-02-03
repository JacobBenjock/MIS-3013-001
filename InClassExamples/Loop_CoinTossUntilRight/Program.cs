using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_CoinTossUntilRight
{
    class Program
    {
        static void Main(string[] args)
        {
            Random coinFlip = new Random();

            int randomNumber = 1;
            int usersGuess = -1;

            while (usersGuess != randomNumber)
            {


                randomNumber = coinFlip.Next(0, 2);
                Console.WriteLine(randomNumber);

                Console.WriteLine("Enter Heads or Tails >>");
                string usersGuessAsString = Console.ReadLine();



                const int HEADS_VALUE = 0;
                const int TAILS_VALUE = 1;
                // conditional to see what the value of a flip would be
                if (usersGuessAsString == "Heads")
                {

                    usersGuess = HEADS_VALUE;
                }
                else if (usersGuessAsString == "Tails")
                {
                    usersGuess = TAILS_VALUE;
                }
                // generates a random number from the flip

                // use the next method on 'rand' and pass in 0,2 to generate a random number that is 0 or 1


                // conditional to describe whether or not they guessed correctly

                if (usersGuess == randomNumber)
                {
                    Console.WriteLine($"Congrats, {usersGuessAsString} was right");
                }
                else
                {
                    Console.WriteLine("You Lose");
                }
        
            } 
            Console.ReadKey();


        }
    }
}
