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
        private float prijs = 3.95f;
        private string type;
        private string model;
        private string os;

        public Mobiel(string nType, string nModel, string nOS, float nPrijs)
        {
            type = nType;
            model = nModel;
            os = nOS;
            prijs = nPrijs;
        }
        public float Btw(int aantal)
        {
            return aantal * prijs + ((aantal * prijs) * btw);
        }

        public void SetPrijs(float nPrijs)
        {
            prijs = nPrijs;
        }

        public string GetType()
        {
            return type;
        }
    }
}
