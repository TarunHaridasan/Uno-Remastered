using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;

namespace Uno
{
    abstract class Game //This is an abstract class because we do not want to instantiate a game object.
    {
        ////////////////////////////////////////Static Variables/////////////////////////////////////
        private static int turn = 0;
        private static int startTime = 0;
        private static CardManager[] players = new CardManager[4] { new CardManager(), new CardManager(), new CardManager(), new CardManager()}; //0-4 for players
        private static CardManager player = players[0]; //Start with player 0
        private static CardManager nextPlayer = players[1];
        private static Deck deck = new Deck();
        private static CardManager discardPile = new CardManager();
        private static int turnDirection = 1;

        ////////////////////////////////////////Access Methods///////////////////////////////////////
        public static CardManager getPlayer(int index)
        {
            return players[index];
        }
        public static CardManager getPlayer()
        {
            return player;
        }
        public static CardManager getNextPlayer()
        {
            return nextPlayer;
        }
        public static int getTurn()
        {
            return turn;
        }
        public static int getStartTime()
        {
            return startTime;
        }
        public static Deck getDeck()
        {
            return deck;
        }
        public static CardManager getDiscardPile()
        {
            return discardPile;
        }
        public static int getTurnDirection()
        {
            return turnDirection;
        }

        ////////////////////////////////////////Methods///////////////////////////////////////////////
        //This method initializes the cards in the player's inventory, and starts the game
        public static void initialize()
        {
            //Give each player 7 cards randomly from the deck
            for (int i=0; i<4; i++)
            {
                for (int j=0; j<7; j++)
                {
                    CardManager player = players[i];
                    Card random = deck.getRandom();
                    deck.transfer(random, player);
                }             
            }

            //Place 1 random card from the deck in the centre pile
            deck.transfer(deck.getRandom(), discardPile);
        }
        
        //C#'s modulo operator does not work as intended for negative dividents, so a custom modulo function was implemented
        public static int mod(int x, int m)
        {
            return (x % m + m) % m;
        }
        
        //This method shifts the current turn
        public static void changeTurn(int shift)
        {
            turn = mod(turn + shift, 4);
            player = players[turn];
            nextPlayer = players[mod(turn + 1, 4)];
        }
        
        //This method allows a card to be played
        public static bool playCard(Card card)
        {
            if (card.isValid())
            {
                card.runEffect();
                player.transfer(card, discardPile);
                return true;
            }
            return false;
        }
        
        //This method allows cards to be drawn if a player cannot go
        public static void drawCard()
        {
            deck.transfer(deck.getRandom(), player);
        }

        //This method reverses the turn direction
        public static void reverseDir()
        {
            if (turnDirection == 1) turnDirection = -1;
            else if (turnDirection == -1) turnDirection = 1;
        }

        //This method sends the highscore to the server
        public async static void sendScore(int score)
        {
            string url = "https://ics4u-isu.jason8908.repl.co/scripts/sendScore.php";
            using (var client = new WebClient())
            {
                NameValueCollection data = new NameValueCollection();
                data["score"] = score.ToString();
                byte[] post = client.UploadValues(url, "POST", data);
                string response = Encoding.UTF8.GetString(post);
                Console.WriteLine(response);
            }
        }

        //Testing functions (DEBUGGING TO BE REMOVED LATER)
        public static void printCards(int player, GameObject start, GameObject target)
        {
            
        }

    }
}
