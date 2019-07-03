using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int nummer = 1;
            int nummer1 = 1;

            while (nummer <= 10946)
            {
                int nummer2 = nummer1;
                nummer1 = nummer + nummer1;
                nummer = nummer2;
                Console.WriteLine(nummer);
                Console.ReadLine();

            }

            }
        }
    }
