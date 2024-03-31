using Windows.ApplicationModel.Chat;

namespace PokerSimConsole
{
    public class CardValue
    {
        private readonly int value;

        public CardValue(int value)
        {
            if (!IsValidValue(value))
                throw new ArgumentException("Value must be between 2 and 14");

            this.value = value;
        }

        private static bool IsValidValue(int value)
        {
            return !(value < 2 || value > 14);
        }

        public int CompareTo(CardValue? other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(CardValue? other)
        {
            return other != null && other.value == this.value;
        }

        public override string? ToString()
        {
            if (value == 14) return "A";
            else if (value == 11) return "J";
            else if (value == 12) return "Q";
            else if (value == 13) return "K";
            else return value.ToString();
        }
    }
}