using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] courseNumber = new int[3];
            string[] courseName = new string[3];



            for (int i = 0; i < courseNumber.Length; i++)
            {
                Console.WriteLine("Please enter your course name e.g MIS,MATH");
                courseName[i] = Console.ReadLine();

                Console.WriteLine("Please enter your course number e.g. 3313");
                courseNumber[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < courseNumber.Length; i++)
            {
                Console.WriteLine($"{courseName[i]}{courseNumber[i]}");
            }

         
            Console.ReadKey();

            

            
        }
    }
}
