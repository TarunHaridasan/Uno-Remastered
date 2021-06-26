using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class CardManager
    {
        ////////////////////////////////////////Instance variables//////////////////////////////////
        private List<Card> cards = new List<Card>();

        ////////////////////////////////////////Access Methods/////////////////////////////////////
        public List<Card> get()
        {
            return cards;
        }
        public Card get(int index)
        {
            return cards[index];
        }
        public void print()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        ////////////////////////////////////////Methods////////////////////////////////////////////
        //The 3 methods below add a card into the cards list
        public void add(Card card)
        {
            cards.Add(card);
        }
        public void add(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                this.cards.Add(card);
            }
        }
        public void add(Card[] cards)
        {
            foreach (Card card in cards)
            {
                this.cards.Add(card);
            }
        }

        //The 3 methods below remove a card from the cards list.
        public void remove(Card card)
        {
            cards.Remove(card);
        }
        public void remove(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                this.cards.Remove(card);
            }
        }
        public void remove(Card[] cards)
        {
            foreach (Card card in cards)
            {
                this.cards.Remove(card);
            }
        }

        //This method swaps two cards in the list
        public void swap(int index1, int index2)
        {
            Card temp = cards[index1];
            cards[index1] = cards[index2];
            cards[index2] = temp;
        }

        //This method transfers a card from the current card manager to another.
        public void transfer(Card card, CardManager destination)
        {
            destination.add(card);
            remove(card);            
        }
        
        //This method returns the length of the cards list.
        public int length()
        {
            return cards.Count;
        }
        
        //Checks if no more cards
        public virtual bool isEmpty()
        {
            if (length()==0)
            {
                return true;
            }
            return false;
        }

        //This method returns all possible cards that can be played in the current state of the game.
        public List<Card> moves()
        {
            List<Card> moves = new List<Card>();
            foreach (Card card in cards)
            {
                if (card.isValid())
                {
                    moves.Add(card);
                }
            }
            return moves;
        }

        //This method checks if no cards can be played
        public bool isStuck()
        {
            List<Card> moves = this.moves();
            if (moves.Count==0)
            {
                return true;
            }
            return false;
        }        
    }
}
