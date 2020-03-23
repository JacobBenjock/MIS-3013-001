using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipationMaxScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = 5000;
            double min = 0;
            double sumGrade = 0;
            List<double>studentGrades = new List<double>();
            string shouldContinue;
            do
            {
                Console.WriteLine("Please enter your exam scores");
                studentGrades.Add(Convert.ToDouble(Console.ReadLine()));

                
                Console.WriteLine("Would you like to enter another score?");
                shouldContinue = Console.ReadLine();



            } while (shouldContinue == "Yes");

            
            for (int i = 0; i < studentGrades.Count; i++)
            {
                sumGrade = studentGrades[i] + sumGrade;
               
                
            }

            

            double average = sumGrade / studentGrades.Count;

            for (int i = 0; i < length; i++)
            {

            }

            Console.WriteLine($"Your average is {average}");
            Console.WriteLine($"Your max score is {max}");
            Console.WriteLine($"Your minimum score is {min}");

            Console.ReadKey();

            






            

        }
    }
}
