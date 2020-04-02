using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesAndRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Circles> circles = new List<Circles>();

            Circles firstCircle = new Circles();
            firstCircle.Radius = 5;
            circles.Add(firstCircle);

            Circles secondCircle = new Circles();
            secondCircle.Radius = 8;
            circles.Add(secondCircle);

            List<Rectangle> rectangle = new List<Rectangle>();

            Rectangle firstRectangle = new Rectangle();
            firstRectangle.Length = 5;
            firstRectangle.Width = 10;
            rectangle.Add(firstRectangle);

            Rectangle secondRectangle = new Rectangle();
            secondRectangle.Length = 7;
            secondRectangle.Width = 14;
            rectangle.Add(secondRectangle);

            Console.WriteLine($"The length of rectangle number one is {firstRectangle.Length} and width is {firstRectangle.Width} and {firstRectangle.CalculateArea()}");
            Console.WriteLine($"The length of rectangle number two is {secondCircle.Radius} and width is {secondCircle.CalculateArea()}");

            

            

            Console.ReadKey();



        }
    }
}
