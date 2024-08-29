using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_Jack_Console
{
    internal class Game
    {
        private Kortlek kortlek;
        private Hand dealer;
        private Hand player;

        public Game()
        {
            kortlek = new Kortlek();
            kortlek.Blanda();
            dealer = new Hand("Dealer");
            player = new Hand("Ada Lovelace");
            Run();
        }

        public void Run()
        {
            kortlek = new Kortlek();
            kortlek.Blanda();
            dealer = new Hand("Dealer");
            dealer.TaEmotKort(kortlek.GeKort());

            player = new Hand("Player");
            player.TaEmotKort(kortlek.GeKort());
            player.TaEmotKort(kortlek.GeKort());

            player.SkrivUt();
            dealer.SkrivUt();

            Console.WriteLine("Vill du ha ett kort till? (j/n)");
            var svar = Console.ReadLine();
            while (svar == "j")
            {
                player.TaEmotKort(kortlek.GeKort());
                player.SkrivUt();
                Console.WriteLine("Vill du ha ett kort till? (j/n)");
                svar = Console.ReadLine();
            }
            while (dealer.RäknaPoäng() < 17)
            {
                dealer.TaEmotKort(kortlek.GeKort());
            }
            dealer.SkrivUt();
            Console.WriteLine("Dealer won");

        }
    }
}
