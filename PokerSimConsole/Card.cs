namespace PokerSimConsole
{
    public class Card(Suit suit, CardValue value) : IEquatable<Card>
    {
        private readonly Suit suit = suit;
        private readonly CardValue value = value;

        public CardValue Value { get { return value; } }
        public Suit Suit { get { return suit; } }

        public override string ToString()
        {
            return suit.ToString() + value.ToString();
        }

        public static bool operator ==(Card? a, Card? b)
        {
            ArgumentNullException.ThrowIfNull(a);
            ArgumentNullException.ThrowIfNull(b);
            return a.Value == b.Value;
        }

        public static bool operator !=(Card? a, Card? b)
        {
            ArgumentNullException.ThrowIfNull(a);
            ArgumentNullException.ThrowIfNull(b);
            return !(a == b);
        }

        public static bool operator <(Card? a, Card? b)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a));
            }

            if (b is null)
            {
                throw new ArgumentNullException(nameof(b));
            }

            return a.Value < b.Value;
        }

        public static bool operator >(Card? a, Card? b)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a));
            }

            if (b is null)
            {
                throw new ArgumentNullException(nameof(b));
            }

            return a.Value > b.Value;
        }

        public static bool operator <=(Card? a, Card? b)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a));
            }

            if (b is null)
            {
                throw new ArgumentNullException(nameof(b));
            }

            return a.Value <= b.Value;
        }

        public static bool operator >=(Card? a, Card? b)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a));
            }

            if (b is null)
            {
                throw new ArgumentNullException(nameof(b));
            }

            return a.Value >= b.Value;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public bool Equals(Card other)
        {
            return other == this;
        }

        public override bool Equals(object? obj)
        {
            return obj is Card card && Equals(card);
        }
    }
}