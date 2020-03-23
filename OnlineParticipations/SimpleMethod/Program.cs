using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalSound = "";
            Console.WriteLine("Which animal would you like to hear?");
            string answer = Console.ReadLine();

            if (answer == "Cow")
            {
                animalSound = Speak("Moo");
            }
            else if (answer == "Pig")
            {
                animalSound = Speak("Oink");
            }
            else if (answer == "Dog")
            {
                animalSound = Speak("Bark Bark Bark");
            }
            else if (answer == "Cat")
            {
                animalSound = Speak("Meow");
            }

            Console.WriteLine($"The sound a {answer} makes is {animalSound}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        static string Speak(string sound)
        {

            return sound;
        }
    }
}
