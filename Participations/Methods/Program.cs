using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 3
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
            List<double> mis3013Grades = new List<double>();
            mis3013Grades.Add(.75);
            mis3013Grades.Add(.45);
            mis3013Grades.Add(.65);

            List<double> mis3033Grades = new List<double>();
            mis3033Grades.Add(.56);
            mis3033Grades.Add(.36);
            mis3033Grades.Add(.96);

            studentGrades.Add("MIS3033", mis3033Grades);
            studentGrades.Add("MIS3013", mis3013Grades);

            foreach (var courseCode in studentGrades.Keys)
            {
                List<double> currentGrades = studentGrades[courseCode];

                double courseCodeAverage = Average(currentGrades);
                Console.WriteLine($"The average for {courseCode} is {(courseCodeAverage / currentGrades.Count)}");
            }
            double average = Average(scores)

            Console.ReadKey();
            

        }
        /// <summary>
        /// Provided a list of double values, this function will calculate the average
        /// </summary>
        /// <param name="values"> A List of double values to calculate the average </param>
        /// <returns> Return the average of the values </returns>
        static double Average(List<double> values)
        {
            double sum = 0;

            foreach (var value in values)
            {
                sum += value;
            }


            return sum / values.Count;
        }
    }
}
