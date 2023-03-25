using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviDomaci
{
    public abstract class Karta
    {
        private int id;

        protected string valjal;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public abstract bool proveraValjanosti(int cena, DateTime datum);

        public override string ToString()
        {
            return "Karta " + this.id + " " + valjal;
        }
    }
}
