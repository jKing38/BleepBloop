using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int computerGuess = PickANumber();
            int userGuess;
            bool gameOver = false;
            List<int> guessList = new List<int>();
            do
            {
                do
                {
                    Console.WriteLine("Enter a guess between 1 and 20: ");
                    if (int.TryParse(Console.ReadLine(), out userGuess))
                    {
                        if (userGuess > 0 && userGuess < 21)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was not in range!!!");
                        }
                    }
                    else
                        Console.WriteLine("That was not a valid guess!");
                } while (true);

                if (guessList.Contains(userGuess))
                {
                    Console.WriteLine("You already guessed that!");
                }
                else
                {
                    guessList.Add(userGuess);
                    if (userGuess == computerGuess)
                    {
                        gameOver = true;
                    }
                    if (userGuess > computerGuess)
                    {
                        Console.WriteLine("Lower!");
                    }
                    if (userGuess < computerGuess)
                    {
                        Console.WriteLine("Higher!");
                    }
                }
            } while (!gameOver);
            Console.WriteLine("You guessed it in {0} guesses!", guessList.Count);
            Console.WriteLine("Your guesses were....");
            foreach (int guess in guessList)
            {
                Console.Write(guess+ ", ");
            }
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }

        public static int PickANumber()
        {
            Random rng = new Random();
            return rng.Next(1, 21);
        }
    }
}
