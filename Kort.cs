using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_Jack_Console
{
    internal class Kort
    {
        public string Färg { get; private set; }
        public int Valör { get; }

        public Kort(string färg, int valör)
        {
            Färg = färg;
            Valör = valör;
        }
        public override String ToString()
        {
            return Färg + " " + ValörToString(Valör);
        }
        private string ValörToString(int valör)
        {
            if (valör == 14)
            {
                return "Ess";
            }
            else if (valör == 11)
            {
                return "Knekt";
            }
            else if (valör == 12)
            {
                return "Dam";
            }
            else if (valör == 13)
            {
                return "Kung";
            }
            else
            {
                return valör.ToString();
            }
        }
    }
}
