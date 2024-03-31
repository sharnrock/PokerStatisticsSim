using PokerSimConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Collections;

namespace PokerSimConsole
{
    internal class Deck
    {
        private readonly List<Card> cards;

        private Deck()
        {
            cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int i = 2; i < 14; i++)
                {
                    cards.Add(new Card(suit, new CardValue(i)));
                }
            }
        }

        private void shuffle()
        {
            //random.shuffle(self.cards);
            //print(self.cards);
        }

        private Card draw()
        {
            //assert(len(self.cards));
            //return self.cards.pop(0);
            return cards[0];
        }

        private void remove(Card card)
        {
            //self.cards.remove(card);
        }
    }
}