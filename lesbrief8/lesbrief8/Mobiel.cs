using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesbrief8
{
    class Mobiel
    {
        const float btw = 0.21f;
        public float prijs = 3.95f;
        public string Type;
        public string Model;
        public string OS;

        public Mobiel(string nType, string nModel, string nOS)
        {
            Type = nType;
            Model = nModel;
            OS = nOS;
        }
        public float Btw(int aantal)
        {
            return aantal * prijs + ((aantal * prijs) * btw);
        }


    }
}
