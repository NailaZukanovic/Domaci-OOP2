using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviDomaci
{
    public class PojedinacnaKarta : Karta
    {
        private int uplacenIznos = 50;

        public int UplacenIznos
        {
            get { return uplacenIznos; }
            set { uplacenIznos = value; }
        }

        public void Dopuna(int iznos)
        {
            uplacenIznos += iznos;
        }

        public override bool proveraValjanosti(int cena, DateTime datum)
        {
            if (uplacenIznos > cena)
            {
                uplacenIznos -= cena;
                   this.valjal = "valjana";
                return true;

            }
            this.valjal = "nije valjana";
                return false;
        }
        
      

    }
}
