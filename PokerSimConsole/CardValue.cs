
    public class CardValue(int value)
    {
        public int Value { get; set; } = value;

        public override string? ToString()
        {
            if (Value == 14) return "A";
            else if (Value == 11) return "J";
            else if (Value == 12) return "Q";
            else if (Value == 13) return "K";
            else return Value.ToString();
        }
    }
