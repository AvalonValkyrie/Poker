using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baldwin_Asg4_Poker
{
    public class Card
    {
        public enum Suits { Clubs, Daimonds, Hearts, Spades };
        private int rank;
        private Suits suit;
        private int imageListIndex;

        public Card()
        {

        }

        public Card(int rank, Suits suit, int imageListIndex)
        {
            if (rank > 13)
                rank = 13;
            if (rank < 1)
                rank = 1;
            this.rank = rank;
            this.suit = suit;
            this.imageListIndex = imageListIndex;
        }

        public string getRankSuit(Card card)
        {
            string rankSuit = "";
            string cardRank = "";
            string cardSuit = "";

            cardRank = card.Rank.ToString();
            cardSuit = (card.suit.ToString()).Substring(0, 1);
            cardSuit = cardSuit.ToUpper();

            rankSuit = cardRank + cardSuit;
            return rankSuit;
        }

        public int Rank { get => rank; set => rank = value; }
        internal Suits Suit { get => suit; set => suit = value; }
        public int ImageListIndex { get => imageListIndex; set => imageListIndex = value; }
    }
}
