namespace PokerSimConsole
{
    public class Deck
    {
        private Stack<Card> cards;
        private static readonly Random rng = new();

        private Deck()
        {
            cards = new Stack<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int i = 2; i < 14; i++)
                {
                    cards.Push(new Card(suit, new CardValue(i)));
                }
            }
        }

        public void Shuffle()
        {
            cards = new Stack<Card>([.. cards.OrderBy(_ => rng.Next())]);
        }

        public Card Draw()
        {
            return cards.Pop();
        }
    }
}