using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInfo("Jacob Benjock", "MIS-3013", "03/09/2020");
            string newCalculation = "";
            double answer = 0;
            double leftoverValue = 0;
            do
            {
                Console.WriteLine("Which calculation would you like to use? e.g Add, Subract, Multiply, Divide");
                string calculation = Console.ReadLine();
                Console.WriteLine("What is your first value?");
                double v1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is your second value?");
                double v2 = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Would you like to try another calculation? e.g Yes, No");
                newCalculation = Console.ReadLine();

                if (calculation == "Add")
                {
                    answer = Add(v1, v2);

                }
                else if (calculation == "Subract")
                {
                    answer = Subtract(v1, v2);
                }
                else if (calculation == "Multiply")
                {
                    answer = Multiply(v1, v2);
                }
                else if (calculation == "Divide")
                {
                    answer = Divide(v1, v2);
                }

                Console.WriteLine($"The answer for your calculation(s) is {answer}");

                if (newCalculation == "Yes")
                {
                    Console.WriteLine("Would you like to keep the answer from your last question as the first number for you next?");
                    string userResult = Console.ReadLine().ToLower();

                    if (userResult == "Yes")
                    {
                        answer = leftoverValue;
                    }
                }

            } while (newCalculation.ToLower() == "yes");

            if (newCalculation.ToLower() == "no")
            {
                Console.WriteLine("Thank you for using my app!");
            }

            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        static double Add(double v1, double v2)
        {
            return v1 + v2;
        }
        static double Subtract(double v1, double v2)
        { 
            return v1 - v2;
        }
        static double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }
        static double Divide(double v1, double v2)
        {
            return v1 / v2;
        }
        static void DeveloperInfo(string developerName, string className, string dateOfWriting)
        {
            Console.WriteLine($"{developerName} wrote this application for {className} on {dateOfWriting}");
        }
    }
}
