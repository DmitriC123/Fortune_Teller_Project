using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine().ToLower();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine().ToLower();

            Console.WriteLine("How old are you?");
            int Age = int.Parse(Console.ReadLine());
            int evenAge = 10;
            int oddAge = 5;
            if (Age % 2 == 0)
            {
                Age = 10;
            }
            else
            {
                Age = 5;
            }

            Console.WriteLine("What month were you born in as a number?");
            int Month = int.Parse(Console.ReadLine().ToLower());


            if (Month >= 0 && Month <= 4)
            {
                Month = 100000;
            }
            else if (Month >= 5 && Month <= 8)
            {
                Month = 500000;
            }
            else if (Month >= 9 && Month <= 12)
            {
                Month = 1000000;
            }
            else if (Month > 12)
            {
                Month = 0;
            }

            string transportation = "";
            string Red;
            string Orange;
            string Yellow;
            string Green;
            string Blue;
            string Indigo;
            string Violet;
            string help;
            Console.WriteLine("What is your favorite color out of ROYGBIV? If you don't know what ROYGBIV is, type help.");
            string Color = Console.ReadLine().ToLower();

            if (Color == "help")
            {
                Console.WriteLine("Red \nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet");
                Console.WriteLine("What is your favorite color?");
                Color = Console.ReadLine().ToLower();

            }

            if (Color == "Red")
            {
                transportation = "bike";
            }
            else if (Color == "orange")
            {
                transportation = "Car";
            }
            else if (Color == "yellow")
            {
                transportation = "bus";
            }
            else if (Color == "green")
            {
                transportation = "Unicycle";
            }
            else if (Color == "blue")
            {
                transportation = "Boat";
            }
            else if (Color == "indigo")
            {
                transportation = "Skateboard";
            }
            else if (Color == "violet")
            {
                transportation = "Surfboard";
            }
           
            else
            {
                transportation = "Your feet";
            }
            

            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
            string location;
            if (siblings == 0)
            {
                location = "Hawaii";
            }
            else if (siblings == 1)
            {
                location = "Mexico";
            }
            else if (siblings == 2)
            {
                location = "Portugal";
            }
            else if (siblings == 3)
            {
                location = "Spain";
            }
            else if (siblings >= 3)
            {
                location = "Bad vacation spot";
            }
            else
            {
                location = "Homeless";
            }

            Console.WriteLine(firstName + " " + lastName + " " + "will retire in " + Age + " " + "years with " + Month + "," + "a vacation home in " + location + " " + "and a " + transportation);

        }
    }
}
