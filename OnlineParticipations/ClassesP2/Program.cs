using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Toy lego = new Toy();
            lego.Manufacturer = "Hasbro";
            lego.Name = "Donald Trump";
            lego.Price = 23.99;
            
            

            Toy yahtzee = new Toy();
            yahtzee.Manufacturer = "Penguin";
            yahtzee.Name = "Game";
            yahtzee.Price = 14.99;



        }
    }
}
