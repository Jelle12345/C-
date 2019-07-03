using System;

namespace Korting
{
    class Program
    {
        static void Main(string[] args)
        {
            const int kortingsLeeftijd = 20;
            Console.Write("Wat is uw leeftijd? ");
            int leeftijd = Convert.ToInt16(Console.ReadLine());
            if (leeftijd < 113)
            {
                if (leeftijd > kortingsLeeftijd)
                {
                    Console.WriteLine("U komt in aanmerking voor een korting.");
                }
            }
            else if (leeftijd <= 0)
            {
                Console.WriteLine("U komt in aanmerking voor een korting.");
            }
            else
            {
                Console.WriteLine("Helaas geen korting.");
            }

            Console.ReadLine();
        }
    }
}