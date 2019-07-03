using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesbrief_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vul hier je eerste getal in: ");
            int getal1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Wat is je tweede getal?: ");
            int getal2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Kies hieruit: x,/,+,-");
            char som = Convert.ToChar(Console.ReadLine());

            if (som == 'x')
            {
                Console.WriteLine(getal1 * getal2);
                Console.ReadLine();
            }
            else if (som == '/')
            {
                Console.WriteLine(getal1 / getal2);
                Console.ReadLine();
            }
            else if (som == '+')
            {
                Console.WriteLine(getal1 + getal2);
                Console.ReadLine();
            }
            else if (som == '-')
            {
                Console.WriteLine(getal1 - getal2);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Bro, wat heb je nou geschreven??!");
                Console.ReadLine();
            }

        }
    }
}
