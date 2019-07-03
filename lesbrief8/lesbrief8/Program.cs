using System;

namespace lesbrief8
{
    class Program
    {

        static void Main(string[] args)
        {
            Mobiel mobiel1 = new Mobiel();
            mobiel1.Type = "Iphone";
            mobiel1.Model = "Iphone X";
            mobiel1.OS = "Apple IOS";

            Console.WriteLine(mobiel1.Type);
            Console.WriteLine(mobiel1.Model);
            Console.WriteLine(mobiel1.OS);

            Console.ReadLine();
        }
    }
}