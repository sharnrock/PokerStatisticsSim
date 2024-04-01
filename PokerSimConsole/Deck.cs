namespace PokerSimConsole
{
    internal class Deck
    {
        private Stack<Card> cards;
        private static Random rng = new Random();

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

        private void Shuffle()
        {
            cards = new Stack<Card>([.. cards.OrderBy(_ => rng.Next())]);
        }

        private Card Draw()
        {
            return cards.Pop();
        }

        private void Remove(Card card)
        {
            //cards.remove(card);
        }
    }
}