using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Card
    {
        ////////////////////////////////////////Instance variables///////////////////////////////
        protected String colour;
        private int value;
        private bool isWild = false;
        private bool isVisible = false;

        ////////////////////////////////////////Constructors/////////////////////////////////////
        public Card(String colour, int value, bool isWild)
        {
            this.colour = colour;
            this.value = value;
            this.isWild = isWild;
        }

        ////////////////////////////////////////Access Methods///////////////////////////////////
        public String getColour()
        {
            return colour;
        }
        public int getValue()
        {
            return value;
        }
        public bool getIsWild()
        {
            return isWild;
        }
        public bool getIsVisible()
        {
            return isVisible;
        }

        ////////////////////////////////////////Methods//////////////////////////////////////////
        //This method flips the card to make it visible to all players
        public void flip()
        {
            isVisible = !isVisible;
        }
        
        //This method checks if the card can be played at the current state of the game
        public bool isValid()
        {
            CardManager discardPile = Game.getDiscardPile();
            Card previousCard = discardPile.get(discardPile.length() - 1); //Get the last played card
            if (previousCard.colour==colour || previousCard.value == value || isWild) //If either the colour or value is the same, then it is valid
            {
                return true;
            }
            return false;
        }
        
        //This method runs the effect of the card
        public virtual void runEffect() //CHANGE STRING TO USER LATER
        {
            Console.Write("THIS iS RUN");
        }
        
        //Overrides the defauly ToString method. This method is called when Console.WriteLine() tries to display a Card object.
        public override string ToString()
        {
            return colour + " " + value;
        }
    }
}
