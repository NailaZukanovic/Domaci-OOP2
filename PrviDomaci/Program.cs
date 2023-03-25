using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviDomaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AparatZaKafu aparat = new AparatZaKafu();
            MesecnaKarta meskar = new MesecnaKarta();

            meskar.Vlasnik = "Naila";
            meskar.DatumVazenja = Convert.ToDateTime("04.03.2000.");
            meskar.Id = 0;
            meskar.proveraValjanosti(300, Convert.ToDateTime("04.03.2000."));
            aparat.DodajKartu(meskar);

            
            PojedinacnaKarta pojkar = new PojedinacnaKarta();

            pojkar.Id = 1;
            pojkar.UplacenIznos = 250;

            pojkar.proveraValjanosti(300, Convert.ToDateTime("04.03.2000."));


            aparat.DodajKartu(pojkar);

            Console.WriteLine(aparat.ToString());

            Console.ReadLine();

        }
    }
}
