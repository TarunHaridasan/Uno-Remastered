using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Deck : CardManager
    {
        ////////////////////////////////////////Constructor/////////////////////////////////////
        public Deck()
        {
            fill(); //Fill the deck when it is created
        }

        ////////////////////////////////////////Methods/////////////////////////////////////////
        //This method fills the deck with Uno cards
        public void fill()
        {
            //Empty the current cards
            remove(get());

            //Regular cards 0-9
            for (int i=0; i<10; i++)
            {
                add(new Card("red", i, false));
                add(new Card("yellow", i, false));
                add(new Card("green", i, false));
                add(new Card("blue", i, false));
            }

            //Regular cards 0-9
            for (int i = 1; i < 10; i++)
            {
                add(new Card("red", i, false));
                add(new Card("yellow", i, false));
                add(new Card("green", i, false));
                add(new Card("blue", i, false));
            }

            //Skips
            for (int i=0; i<2; i++)
            {
                add(new Skip("red"));
                add(new Skip("yellow"));
                add(new Skip("green"));
                add(new Skip("blue"));
            }

            //Reverse
            for (int i = 0; i < 2; i++)
            {
                add(new Reverse("red"));
                add(new Reverse("yellow"));
                add(new Reverse("green"));
                add(new Reverse("blue"));
            }

            //Draw Two
            for (int i = 0; i < 2; i++)
            {
                add(new DrawTwo("red"));
                add(new DrawTwo("yellow"));
                add(new DrawTwo("green"));
                add(new DrawTwo("blue"));
            }

            //Wild Card
            for (int i = 0; i < 4; i++)
            {
                add(new WildCard());                
            }

            //Draw Four
            for (int i = 0; i < 4; i++)
            {
                add(new DrawFour());
            }

            //Fullskip
            for (int i=0; i<4; i++)
            {
                add(new FullSkip());
            }

            //Shuffle the deck
            //shuffle();
        }

        //This method returns a random card from the deck. 
        public Card getRandom()
        {
            if (isEmpty()) //If the deck is empty, it will be filled first.
            {
                fill();
            }
            Random rand = new Random();
            int randomIndex = rand.Next(length());
            return get(randomIndex);
        }

        //This method shuffles cards in the list
        public void shuffle()
        {
            int size = length();
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                int card1 = rand.Next(size);
                int card2 = rand.Next(size);
                swap(card1, card2);
            }
        }
    }
}
