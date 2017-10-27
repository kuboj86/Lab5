using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int numSides = GetNumberOfSides();

            if (RollDice())
            {
                Console.WriteLine($"You rolled a {Roll(numSides)} and a {Roll(numSides)}!");
            }
            else
            {
                Console.WriteLine("OK, see ya later!");
            }
            Console.ReadLine();
            bool stayOrLeave = Option();
        }

        static int Roll(int numSide)
        {
            return random.Next(numSide);
        }

        static int GetNumberOfSides()
        {
            int sides = 0;

            Console.Write("How many sides are there for the two die?:    ");
            while (!int.TryParse(Console.ReadLine(), out sides))
            {
                Console.Write("Please enter a valid number!    ");
            }
            return sides;
        }
        static Boolean RollDice()
        {
            string answer;
            do
            {
                Console.Write("Ready to roll the dice?:   Y/N ");
                answer = Console.ReadLine();
            } while (!(answer.ToLower() == "y" || answer.ToLower() == "n"));
            return (answer == "y");
        }
        private static bool Option()
        {
            {
                string answer;
                do
                {
                    Console.Write("Would you like to play again?:   Y/N ");
                    answer = Console.ReadLine();
                } while (!(answer.ToLower() == "y" || answer.ToLower() == "n"));
                return (answer == "y");
            }
        }
    }
}
