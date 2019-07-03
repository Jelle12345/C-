using System;

namespace Boodschappen
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = "Koffie";
            int aantal;
            float prijsExclBtwK = 3.95f;
            float prijsExlbtwT = 4.12f;
            float prijsExlbtwS = 5.24f;
            float prijsExlbtwK = 1.45f;
            float prijsExlbtwD = 3.42f;
            float prijsExlbtwW = 3.92f;

            float btwPercentage = 0.21f;

            Console.WriteLine("Een pakje koffie kost " + prijsExclBtwK + " ex btw.");
            Console.WriteLine("Een pakje thee kost " + prijsExclBtwT +" ex btw.");
            Console.WriteLine("Een pakje sigaretten kost " + prijsExclBtwS + " ex btw.");
            Console.WriteLine("Een pakje koekjes kost " + prijsExclBtwK + " ex btw.");
            Console.WriteLine("Een pakje drinken kost " + prijsExclBtwD + " ex btw.");
            Console.WriteLine("Een pakje wafels kost " + prijsExclBtwW + " ex btw.");

            aantal = Convert.ToInt32(Console.ReadLine());
            float totaalPrijs = aantal * prijsExclBtw + (aantal * prijsExclBtw) * btwPercentage;

            Console.WriteLine(aantal + " pakken " + product + " kost in totaal " + totaalPrijs);

        }
    }
}