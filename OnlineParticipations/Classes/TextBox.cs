using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class TextBox
    {
        public int Padding { get; set; }

        public ConsoleColor BackColor { get; set; }

        public ConsoleColor ForeColor { get; set; }

        public string Text { get; set; }

        public TextBox()
        {
            Padding = 0;
            
            Text = "";
          
        }
        public void DisplayText()
        {
            Console.ForegroundColor = this.ForeColor;

            Console.BackgroundColor = this.BackColor;

            Console.WriteLine($"{this.Padding} {Text} {this.Padding}");
        }
    }
}
