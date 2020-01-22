using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an String named firstName
            string firstName;


            //Assign a value to firstName (use your name)
            firstName = "Jacob";


            //Create an int named favorite number
            int favoriteNumber = 5;

            double crazyNumber = 4.3564 * favoriteNumber;
            string lastName = "Benjock";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName + " has a favorite number of " + favoriteNumber
                                 + " \nwhich equates to a crazy number of " + crazyNumber);
            // MAKE IT DYNAMIC

            Console.ReadKey();

        }
    }
}
