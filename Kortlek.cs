using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_Jack_Console
{
    internal class Kortlek
    {
        private List<Kort> kortleken = new List<Kort>();

        public Kortlek()
        {
            for (int i = 2; i <= 14; i++)
            {
                kortleken.Add(new Kort("Hjärter", i));
                kortleken.Add(new Kort("Ruter", i));
                kortleken.Add(new Kort("Klöver", i));
                kortleken.Add(new Kort("Spader", i));
            }
        }

        public void SkrivUt()
        {
            foreach (var kort in kortleken)
            {
                Console.WriteLine(kort);
            }
        }

        public void Blanda()
        {
            Random slump = new Random();
            for (int k = 0; k < 10; k++)
            {
                for (int i = 0; i < kortleken.Count; i++)
                {
                    int j = slump.Next(kortleken.Count);
                    Kort temp = kortleken[i];
                    kortleken[i] = kortleken[j];
                    kortleken[j] = temp;
                }
            }
        }

        public Kort GeKort()
        {
            Kort kort = kortleken[kortleken.Count - 1];
            kortleken.RemoveAt(kortleken.Count - 1);
            return kort;
        }
    }
}
