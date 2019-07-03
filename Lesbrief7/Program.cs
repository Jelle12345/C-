using System;

namespace Boodschappen
{
    class Program
    {
        const string product = "Koffie";
        const float prijsExclBtw = 3.95f;
        const float btwPercentage = 0.21f;

        static void Main(string[] args)
        {
            int aantal;

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
