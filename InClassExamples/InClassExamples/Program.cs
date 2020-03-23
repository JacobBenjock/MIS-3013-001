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

            

            for (int i = firstName.Length - 1; i >=0 ; i--)
            {
                Console.Write(firstName[i]);
            }

            


            Console.ReadKey();

        }

    }


}
