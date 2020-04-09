using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP2
{
    class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Aisle { get; set; }

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int number = rand.Next(1, 24);
            string getAisle = $"{Manufacturer[0]}{number}";

            return getAisle;
        }

        
    }
}
