using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TextBox> textBoxes = new List<TextBox>();

            TextBox numberOne = new TextBox();
            numberOne.Padding = 4;
            numberOne.ForeColor = ConsoleColor.Yellow;
            numberOne.BackColor = ConsoleColor.Blue;
            numberOne.Text = "Test Test Test";
            textBoxes.Add(numberOne);


            TextBox numberTwo = new TextBox();
            numberTwo.Padding = 6;
            numberTwo.ForeColor = ConsoleColor.Red;
            numberTwo.BackColor = ConsoleColor.Black;
            numberTwo.Text = "Another Test";
            textBoxes.Add(numberTwo);

            numberOne.DisplayText();
            numberTwo.DisplayText();

            Console.ReadKey();





        }
    }
}
