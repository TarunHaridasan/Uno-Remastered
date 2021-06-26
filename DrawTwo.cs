using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class DrawTwo : SpecialCard
    {
        //Constructor
        public DrawTwo(String colour) : base("DrawTwo", colour, -1, false)
        {
        }

        //This method makes the next player pick up 2 cards
        public override void runEffect()
        {
            CardManager nextPlayer = Game.getNextPlayer();
            Deck deck = Game.getDeck();
            for (int i = 0; i < 2; i++)
            {
                Card card = deck.getRandom();
                deck.transfer(card, nextPlayer);
            }
        }
    }
}
