using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Wacky World of MilHip!");
            string input = "yes";

            while (input.ToLower() == "yes")
            {
                Console.WriteLine("Select the type of measurement to convert: ");
                Console.WriteLine("[1] Inches");
                Console.WriteLine("[2] Fidget Spinners");
                Console.WriteLine("[3] Feet");
                Console.WriteLine("[4] Memes");

                int selection = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose an amount to convert: ");
                double amount = double.Parse(Console.ReadLine());

                if (selection == 1)
                {
                    amount *= 3.5;
                    Console.WriteLine("Amount converts to" + " " + amount + " " + "fidget spinners.");
                }
                else if (selection == 2)
                {
                    amount /= 3.5;
                    Console.WriteLine("Amonut converts to" + " " + amount + " " + "inches.");
                }
                else if (selection == 3)
                {
                    amount *= 5;
                    Console.WriteLine("Amount converts to" + " " + amount + " " + "memes.");
                }
                else if (selection == 4)
                {
                    amount /= 5;
                    Console.WriteLine("Amount converts to" + " " + amount + " " + "feet.");
                }
                else
                {
                    Console.WriteLine("Invalid input! Try again.");
                }

                Console.WriteLine("Wanna do another one? Yes/No");
                input = Console.ReadLine().ToLower();
            }
        }
    }
}
