using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baldwin_Asg4_Poker
{
    public class Deck
    {
        private List<Card> listCards = new List<Card>();

        internal List<Card> Cards { get => listCards; set => listCards = value; }

        public Deck()
        {
            buildDeck();
        }
        public Card drawRandomCard()
        {
            Card card = new Card();
            int cardCount = listCards.Count;

            Random random = new Random(Guid.NewGuid().GetHashCode());
            int randomNumber = random.Next(0, cardCount);

            card = (Card)listCards[randomNumber];
            listCards.RemoveAt(randomNumber);

            return card;
        }
        public Card drawSpecificCard(int cardNum)
        {
            Card card = new Card();
            card = (Card)listCards[cardNum];
            listCards.RemoveAt(cardNum);

            return card;
        }

        private void buildDeck()
        {
            int Rank = 1;
            int imageListIndex = 0;
           
            for (int i = 1; i < 14; i++)
            {
                foreach ( Card.Suits suit in Enum.GetValues(typeof(Card.Suits)))
                {
                    Card card = new Card();
                    card.Rank = Rank;
                    card.Suit = suit;
                    card.ImageListIndex = imageListIndex;
                    listCards.Add(card);
                    imageListIndex++;
                }
                
                Rank++;
            }
        }
        public void resetDeck()
        {
            buildDeck();
        }
    }
}
