using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class DrawFour : SpecialCard
    {
        //Constructor
        public DrawFour() : base("DrawFour", "black", -1, true)
        {
        }

        //This method allows the caster to change the colour of the card. It also makes the next player pick up 4 cards
        public override void runEffect()
        {
            //Change colour
            String newColour = Console.ReadLine();
            colour = newColour;
            //Make the next player pick up 4 cards
            CardManager nextPlayer = Game.getNextPlayer();
            Deck deck = Game.getDeck();
            for (int i=0; i<4; i++)
            {
                Card card = deck.getRandom();
                deck.transfer(card, nextPlayer);
            }
        }
    }
}
