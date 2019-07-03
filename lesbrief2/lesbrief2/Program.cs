using System;

namespace Boodschappen
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = "koffie";
            string product2 = "thee";
            string product3 = "sigaretten";
            string product4 = "koekjes";
            string product5 = "mandarijnen";
            string product6 = "appels";
            string product7 = "bananen";
            string product8 = "paracetamols";
            string product9 = "kiwi's";
            string product10 = "uien";
            int aantal;
            float prijsExclBtw = 3.95f;
            float btwPercentage = 0.21f;

            Console.WriteLine("Een pakje " + product + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Een pakje " + product2 + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Een pakje " + product3 + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Een pakje " + product4 + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Een pakje " + product5 + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Een pakje " + product6 + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Een pakje " + product7 + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Een pakje " + product8 + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Een pakje " + product9 + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Een pakje " + product10 + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Voer een aantal in: ");

            aantal = Convert.ToInt32(Console.ReadLine());
            float totaalPrijs = aantal * prijsExclBtw + (aantal * prijsExclBtw) * btwPercentage;

            Console.WriteLine(aantal + " pakken " + product + " kost in totaal " + totaalPrijs);
            Console.ReadLine();

        }
    }
}
