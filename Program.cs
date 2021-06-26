using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Game.initialize();
            CardManager discardPile = Game.getDiscardPile();          
            Console.WriteLine("Discard Pile Card: ");
            discardPile.get().ForEach(Console.WriteLine);
            Console.WriteLine("=================");

            Card card = new DrawFour();
            Console.WriteLine(Game.playCard(card));

            Console.WriteLine("Discard Pile Card: ");
            discardPile.get().ForEach(Console.WriteLine);
            Console.WriteLine("=================");

            Console.WriteLine("Player 0 Cards:");
            Game.printCards(0);

            Console.WriteLine("Player 1 cards:");
            Game.printCards(1);

            Console.ReadLine(); 
            */

            Game.sendScore(600);

            Console.ReadLine();


        }
    }
}
