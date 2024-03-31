namespace PokerSimConsole
{
    public struct Card : IEquatable<Card>
    {
        public Suit suit;
        public CardValue value;

        public Card(Suit suit, CardValue value)
        {
            this.suit = suit;
            this.value = value;
        }

        public override readonly string ToString()
        {
            return "";
        }

        public static bool operator ==(Card? a, Card? b)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a));
            }

            if (b is null)
            {
                throw new ArgumentNullException(nameof(b));
            }

            return false;
        }

        public static bool operator !=(Card? a, Card? b)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a));
            }

            if (b is null)
            {
                throw new ArgumentNullException(nameof(b));
            }

            return false;
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

            return false;
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

            return false;
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

            return false;
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

            return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public bool Equals(Card other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is Card && Equals((Card)obj);
        }
    }
}