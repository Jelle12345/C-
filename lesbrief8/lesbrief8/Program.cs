using System;

namespace lesbrief8
{
    class Program
    {

        static void Main(string[] args)
        {
            Mobiel mobiel1 = new Mobiel("Iphone", "Iphone X", "Iphone IOS", nPrijs: 700f);
            Mobiel mobiel2 = new Mobiel("Samsung", "Samsung Galaxy S9", "....", nPrijs: 600f);
            mobiel1.SetPrijs(900f);
            mobiel2.SetPrijs(800f);
            
            string welkMobiel;

            string typeIphone = mobiel1.GetType();
            string typeSamsung = mobiel2.GetType();
            

            Console.WriteLine("Welke telefoon wilt u kopen? " + typeIphone + " of " + typeSamsung + "?");
            welkMobiel = Console.ReadLine();

            if (welkMobiel.ToUpper() == "IPHONE")
            {
                Console.WriteLine("Hoeveel " + typeIphone + "s wilt u kopen?");
                int aantalIphone = Convert.ToInt32(Console.ReadLine());

                float totaalPrijsIphone = mobiel1.Btw(aantalIphone);

                Console.WriteLine(aantalIphone + " Iphones kosten in totaal " + totaalPrijsIphone);
            }
            else if (welkMobiel.ToUpper() == "SAMSUNG")
            {
                Console.WriteLine("Hoeveel " + typeSamsung + "s wilt u kopen?");
                int aantalSamsung = Convert.ToInt32(Console.ReadLine());

                 float totaalPrijsSamsung = mobiel2.Btw(aantalSamsung);

                Console.WriteLine(aantalSamsung + " Samsungs kosten in totaal " + totaalPrijsSamsung);
            }

            Console.ReadLine();

        }
    }
}