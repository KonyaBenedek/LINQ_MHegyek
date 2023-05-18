using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoHegyei
{
    public class Hegycsucs
    {
        private string hegy;
        private string hegyseg;
        private int magassag;

        public Hegycsucs(string hegy, string hegyseg, int magassag)
        {
            this.hegy = hegy;
            this.hegyseg = hegyseg;
            this.magassag = magassag;
        }
    }
}
