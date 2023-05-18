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
            this.Hegy = hegy;
            this.Hegyseg = hegyseg;
            this.Magassag = magassag;
        }

        public string Hegy { get => hegy; set => hegy = value; }
        public string Hegyseg { get => hegyseg; set => hegyseg = value; }
        public int Magassag { get => magassag; set => magassag = value; }
    }
}
