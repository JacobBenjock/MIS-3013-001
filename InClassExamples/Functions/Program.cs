using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            List<double> grades = new List<double>();
            do
            {
                Console.WriteLine("Please enter your exam grades");
                string response = Console.ReadLine();
                double grade;

                while (double.TryParse(response, out grade) != true)
                {
                    Console.WriteLine("Sorry you must enter a valid number, please try again"
                     
                }
                grades.Add(grade);
                Console.WriteLine("Do you have another value to enter?");
                answer = Console.ReadLine();
            } while (answer.ToLower() != "no");
        }
        static double GetValidDoubleFromUser(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();
            double grade;

            while (double.TryParse(response, out grade) != true)
            {
                Console.WriteLine("Sorry you must enter a valid number, please try again");
                response = Console.ReadLine();
            }
            return grade;
        }
    }
}
