using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_Jack_Console
{
    internal class Hand
    {
        private List<Kort> handen;
        private string name;

        public Hand(string name)
        {
            handen = new List<Kort>();
            this.name = name;
        }

        public void TaEmotKort(Kort kort)
        {
            handen.Add(kort);
        }

        public void SkrivUt()
        {
            Console.Write(name + ": ");
            foreach (var kort in handen)
            {
                Console.Write(kort + ", ");
            }
            Console.WriteLine(" Poäng: " + RäknaPoäng());
        }

        public int RäknaPoäng()
        {
            int poäng = 0;
            foreach (var kort in handen)
            {
                poäng += kort.Valör;
            }
            return poäng;
        }
    }
}
