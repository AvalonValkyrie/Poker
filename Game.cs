using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baldwin_Asg4_Poker
{
    public class Game
    {
        private List<Card> playerHand = new List<Card>();
        internal List<Card> Cards { get => playerHand; set => playerHand = value; }

        private int credits;
        private int bet;
        public enum Status { InitialDeal, Draw, Score };
        public Deck deck = new Deck();

        public Game()
        {
            buildPlayerHand();
            credits = 100;
            bet = 10;

        }

        public void buildPlayerHand()
        {
            playerHand.Clear();

            Card card = new Card();

            for (int i = 0; i < 5; i++)
            {
                card = deck.drawRandomCard();
                playerHand.Add(card);
            }
        }
        public List<Card> getPlayerHand()
        {
            return (List<Card>)playerHand;
        }

        public void reloadHand()
        {
            deck.resetDeck();
            buildPlayerHand();
        }

        public int Credits { get => credits; set => credits = value; }
        public int Bet { get => bet; set => bet = value; }
    }
}
