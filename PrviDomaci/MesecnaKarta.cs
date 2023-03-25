using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviDomaci
{
    public class MesecnaKarta : Karta
    {
        private string vlasnik;

        public string Vlasnik
        {
            get { return vlasnik; }
            set { vlasnik = value; }
        }

        private DateTime datumVazenja;

        public DateTime DatumVazenja
        {
            get { return datumVazenja; }
            set { datumVazenja = value; }
        }

 
        public override bool proveraValjanosti(int cena, DateTime datum)
        {
            var comp = DateTime.Compare(this.datumVazenja, datum);

            if (Convert.ToBoolean(comp))
                this.valjal = "Valjana";
            else
                this.valjal = "Nije valjana";
            return Convert.ToBoolean(comp);
        }
    }
}
