namespace PokerSimConsole
{
    public class Deck
    {
        private List<Card> cards;
        private static readonly Random rng = new();

        public Deck()
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

        public void Shuffle()
        {
            cards = new List<Card>([.. cards.OrderBy(_ => rng.Next())]);
        }

        public Card Draw()
        {
            var result = cards.First();
            Remove(result);
            return result;
        }

        public void Remove(Card card)
        {
            cards.Remove(card);
        }
    }
}