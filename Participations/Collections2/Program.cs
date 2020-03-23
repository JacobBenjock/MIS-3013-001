using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 3
            Dictionary<string, List<double>>studentGrades = new Dictionary<string, List<double>>();
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

                double courseCodeAverage = 0;

                foreach (var grade in currentGrades)
                {
                    courseCodeAverage += grade;
                }
                Console.WriteLine($"The average for {courseCode} is {(courseCodeAverage/currentGrades.Count)}");
            }


            Console.ReadKey();
        }
        
    }
}
