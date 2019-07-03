using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int aantal = 0; aantal < 3; aantal++)
            {
                string secretWord = "informatica";
                string guessedWord = "";

                if (guessedWord != secretWord)
                {
                    Console.Write("Enter guess: ");
                    guessedWord = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You've won!");
                    Console.ReadLine();
                }
            }
        }
    }
}