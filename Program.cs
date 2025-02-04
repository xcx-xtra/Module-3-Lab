using System;

namespace TacoBurritoLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message and prompt the user for input
            Console.WriteLine("Welcome to the Taco & Burrito Decision Maker!");
            Console.Write("How hungry are you (1-10)? ");
            int hungerLevel = int.Parse(Console.ReadLine());

            // Decide what food to recommend based on the hunger level
            if (hungerLevel >= 8)
            {
                // Recommend both tacos and burritos for extreme hunger
                Console.WriteLine("You're super hungry! Order both tacos and burritos.");
            }
            else if (hungerLevel >= 5)
            {
                // Recommend tacos for moderate hunger
                Console.WriteLine("You're moderately hungry. Go for tacos!");
            }
            else
            {
                // Recommend a burrito for low hunger
                Console.WriteLine("You're not that hungry. Opt for a burrito.");
            }

            // Display a final food recommendation using a ternary operator
            string recommendation = (hungerLevel >= 5) ? "Tacos" : "Burrito";
            Console.WriteLine($"I recommend: {recommendation}");

            // Output a message to the user based on their hunger level using a switch statement
            switch (hungerLevel)
            {
                case 10:
                    Console.WriteLine("You're a taco and burrito champion!");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Taco time!");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Burrito it is!");
                    break;
                default:
                    Console.WriteLine("Maybe just grab a snack.");
                    break;
            } // end switch
        } // end Main
    } // end class Program
} // end namespace TacoBurritoLab