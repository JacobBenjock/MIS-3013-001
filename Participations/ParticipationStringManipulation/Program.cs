// Jacob Benjock
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipationStringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.");
            string mainString = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

            Console.WriteLine("What word do you want to look for? >>");
            string userString = Convert.ToString(Console.ReadLine());

            bool trueOrNot = mainString.Contains(userString);
            Console.WriteLine("'{0}' is in the string '{1}': {2}", userString, mainString, trueOrNot);

            string Replacement = Convert.ToString(Console.ReadLine());
            
            if (mainString.Contains(userString))
            {
                string replacement = userString.Replace(userString, replacement);
                Console.WriteLine("Your word {0} was found", userString);
                



            }
            else if (trueOrNot == false)
            {

                Console.WriteLine("Your word was not found");

                for (int i = replacement.Length;  i >= 0; i--)
                {
                    Console.Write(Replacement[i]);
                }
                
            }
            Console.ReadKey();
            
        }
        
        
    }
    
}
