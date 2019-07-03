using System;

namespace Boodschappen
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = "Koffie";
            int aantal;
            float prijsExclBtw = 3.95f;
            float btwPercentage = 0.21f;

            Console.WriteLine("Een pakje " + product + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Voer een aantal in: ");

            aantal = Convert.ToInt32(Console.ReadLine());
            float totaalPrijs = aantal * prijsExclBtw + BtwBerekening(aantal, prijsExclBtw, btwPercentage);
            Console.WriteLine(aantal + " pakken " + product + " kost in totaal " + totaalPrijs);
            Console.ReadLine();

        }
        public static float BtwBerekening(int aantal, float btwPrijs, float btwPercentage)
        {
            return (aantal * btwPrijs) * btwPercentage;
        }
    }
}