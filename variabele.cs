using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            Console.WriteLine("Wat is jouw naam?");
            naam = Console.ReadLine();
            Console.WriteLine("Hello " + naam);
        }
    }
}