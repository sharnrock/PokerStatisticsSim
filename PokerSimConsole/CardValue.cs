namespace PokerSimConsole
{
    public class CardValue : IEquatable<CardValue>
    {
        private readonly int value;

        public CardValue(int value)
        {
            if (!IsBetweenTwoAndAce(value))
                throw new ArgumentException("Value must be between 2 and 14");

            this.value = value;
        }

        private static bool IsBetweenTwoAndAce(int value)
        { return !(value < 2 || value > 14); }

        public static bool operator ==(CardValue a, CardValue b)
        { return a.value == b.value; }

        public static bool operator !=(CardValue a, CardValue b)
        { return !a.Equals(b); }

        public static bool operator <(CardValue a, CardValue b)
        { return a.value < b.value; }

        public static bool operator >(CardValue a, CardValue b)
        { return a.value > b.value; }

        public static bool operator >=(CardValue a, CardValue b)
        { return a.value >= b.value; }

        public static bool operator <=(CardValue a, CardValue b)
        { return a.value <= b.value; }

        public static int operator - (CardValue a, CardValue b)
        { return a.value - b.value; }

        public bool Equals(CardValue? other)
        {
            ArgumentNullException.ThrowIfNull(other);
            return other == this;
        }

        public override string? ToString()
        {
            if (value == 14) return "A";
            else if (value == 11) return "J";
            else if (value == 12) return "Q";
            else if (value == 13) return "K";
            else return value.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is null)
            {
                return false;
            }

            return this == ((CardValue)obj);
        }

        public override int GetHashCode()
        {
            return value;
        }
    }
}