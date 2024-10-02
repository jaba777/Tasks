using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.controllers
{
    internal class Game
    {
        public static string game()
        {
            Random rand = new Random();

            // Get range from user
            Console.Write("Enter the lower bound (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the upper bound (b): ");
            int b = int.Parse(Console.ReadLine());

            // Validate input range
            if (a >= b)
            {
                
                return "Invalid range a must be lower than b";
            }
            int pcNum = rand.Next(a, b+1);

            Console.Write("Enter the number of attempts (n): ");
            int n = int.Parse(Console.ReadLine());

            int attempts = 0;

            bool playerWin = false;

            while (attempts < n)
            {
                Console.Write($"Attempt {attempts + 1}: Guess the number: ");
                int userGuess = int.Parse(Console.ReadLine());

                if(userGuess == pcNum)
                {
                    playerWin = true;
                    break;
                } else if(userGuess < pcNum)
                {
                    Console.WriteLine("Your number is less");
                } else if(userGuess > pcNum)
                {
                    Console.WriteLine("Your number is more");
                }

                attempts++;
            }

            return playerWin ? "You Won! Congrats": $"You lost! Number was {pcNum}";
        }
    }
}
