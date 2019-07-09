using System;

namespace lesbrief8
{
    class Program
    {

        static void Main(string[] args)
        {
            Mobiel mobiel1 = new Mobiel("Iphone", "Iphone X", "Iphone IOS");
            Mobiel mobiel2 = new Mobiel("Samsung", "Samsung Galaxy S9", "....");
            mobiel1.prijs = 700f;
            mobiel2.prijs = 600f;

            string welkMobiel;

            Console.WriteLine("Welke telefoon wilt u kopen? " + mobiel1.Type + " of " + mobiel2.Type + "?");
            welkMobiel = Console.ReadLine();

            if (welkMobiel.ToUpper() == "IPHONE")
            {
                Console.WriteLine("Hoeveel " + mobiel1.Type + "s wilt u kopen?");
                int aantalIphone = Convert.ToInt32(Console.ReadLine());

                float totaalPrijsIphone = mobiel1.Btw(aantalIphone);

                Console.WriteLine(aantalIphone + " Iphones kosten in totaal " + totaalPrijsIphone);
            }
            else if (welkMobiel.ToUpper() == "SAMSUNG")
            {
                Console.WriteLine("Hoeveel " + mobiel2.Type + "s wilt u kopen?");
                int aantalSamsung = Convert.ToInt32(Console.ReadLine());

                 float totaalPrijsSamsung = mobiel2.Btw(aantalSamsung);

                Console.WriteLine(aantalSamsung + " Samsungs kosten in totaal " + totaalPrijsSamsung);
            }
            Console.ReadLine();
        }
    }
}