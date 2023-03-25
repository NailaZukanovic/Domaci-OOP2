using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviDomaci
{
    public class AparatZaKafu
    {
        List<Karta> karte = new List<Karta>();

        public bool DodajKartu(Karta karta)
        {
            if (!karte.Exists(k => k.Id == karta.Id))
            {
                this.karte.Add(karta);
                return true;
            }
            else return false;

        }

        public bool proveraValjanosti()
        {
            foreach (var karta in this.karte)
            {
                if (karta.proveraValjanosti(3,new DateTime()) == false)
                    return false;
            }

            return true;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var karta in this.karte)
            {
                result += karta.ToString();
            }

            return result;

        }
    }
}
