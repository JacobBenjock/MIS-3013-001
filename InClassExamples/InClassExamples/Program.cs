using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassExamples
{
    class Program
    {
        const string MESSAGE = "Thank you for using my application!";
    
        static void Main(string[] args)
        {
            //Create an String named firstName
            string firstName;


            //Assign a value to firstName (use your name)
            firstName = "Jacob";


            //Create an int named favorite number
            int favoriteNumber;


            string lastName = "Benjock";


            //MAKE IT DYNAMIC
            Console.WriteLine("Please enter your first name: >>");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: >>");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite number: >>");
            favoriteNumber = Convert.ToInt32(Console.ReadLine());

            string fullName = firstName + " " + lastName;
            double crazyNumber = 4.23 * favoriteNumber;
            Console.WriteLine(fullName + " has a favorite number of " + favoriteNumber
                                 + " \nwhich equates to a crazy number of " + crazyNumber);


            Console.ReadKey();

        }

    }


}
