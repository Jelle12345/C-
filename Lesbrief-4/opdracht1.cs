using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "informatica";
            string guessedWord = "";
            int aantal = 0;

            while (aantal < 3)
            {
                Console.Write("Enter guess: ");
                guessedWord = Console.ReadLine();
                aantal = aantal + 1;
            }
        }
    }
}