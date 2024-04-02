namespace PokerSimConsole
{
    public class CommunityCards
    {
        public Card Flop1 { get; set; }
        public Card Flop2 { get; set; }
        public Card Flop3 { get; set; }
        public Card Turn { get; set; }
        public Card River { get; set; }

        public CommunityCards()
        {
            Flop1 = new Card(Suit.Diamond, new CardValue(2));
            Flop2 = new Card(Suit.Diamond, new CardValue(2));
            Flop3 = new Card(Suit.Diamond, new CardValue(2));
            Turn = new Card(Suit.Diamond, new CardValue(2));
            River = new Card(Suit.Diamond, new CardValue(2));
        }
    }

    public enum HandRank
    {
        HighCard,
        OnePair,
        TwoPair,
        ThreeOfaKind,
        Straight,
        Flush,
        FullHouse,
        FourOfaKind,
        StraightFlush,
        RoyalFlush
    }

    public class Hand(Card personal1, Card personal2, CommunityCards community) : IComparable<Hand>
    {
        private List<Card> Cards { get; set; } = [personal1, personal2, community.Flop1, community.Flop2, community.Flop3, community.Turn, community.River];

        public HandRank GetHandRank()
        {
            if (HasStraightFlush())
                return HandRank.StraightFlush;
            else if (Has4OfaKind())
                return HandRank.FourOfaKind;
            else if (HasFullHouse())
                return HandRank.FullHouse;
            else if (HasFlush())
                return HandRank.Flush;
            else if (HasStraight())
                return HandRank.Straight;
            else if (HasThreeOfaKind())
                return HandRank.ThreeOfaKind;
            else if (HasTwoPair())
                return HandRank.TwoPair;
            else if (HasOnePair())
                return HandRank.OnePair;
            else
                return HandRank.HighCard; // Default return
        }



        public Card? GetHighCard()
        {
            return Cards.Max();
        }

        public static bool operator ==(Hand a, Hand b)
        {
            return (a.GetHandRank() == b.GetHandRank());
        }

        public static bool operator !=(Hand a, Hand b)
        {
            return (a.GetHandRank() != b.GetHandRank());
        }

        public static bool operator <(Hand a, Hand b)
        {
            return (a.GetHandRank() < b.GetHandRank());
        }

        public static bool operator >(Hand a, Hand b)
        {
            return (a.GetHandRank() > b.GetHandRank());
        }

        public static bool operator <=(Hand a, Hand b)
        {
            return (a.GetHandRank() <= b.GetHandRank());
        }

        public static bool operator >=(Hand a, Hand b)
        {
            return (a.GetHandRank() >= b.GetHandRank());
        }

        public int CountPairMatches()
        {
            var data = CountValueMatches();
            int pairs = 0;
            foreach (int datum in data.Values)
                if (datum == 2)
                    pairs += 1;
            return pairs;

        }

        public bool HasOnePair()
        {
            return CountPairMatches() == 1;
        }

        public bool HasTwoPair()
        {
            return CountPairMatches() == 2;
        }

        public bool HasThreeOfaKind()
        {
            var data = this.CountValueMatches();
            foreach (int datum in data.Values)
                if (datum == 3)
                    return true;
            return false;
        }

        public bool HasFullHouse()
        {
            if (!HasThreeOfaKind())
                return false;
            var data = this.CountValueMatches();
            foreach (int datum in data.Values)
                if (datum > 1)
                    return true;
            return false;
        }

        public bool Has4OfaKind()
        {
            var data = this.CountValueMatches();
            foreach (int datum in data.Values)
                if (datum == 4)
                    return true;
            return false;
        }

        public Dictionary<CardValue, int> CountValueMatches()
        {
            Dictionary<CardValue, int> data = [];
            foreach (Card card in Cards)
            {
                if (data.ContainsKey(card.Value))
                    data[card.Value] += 1;
                else
                    data[card.Value] = 1;
            }
            return data;
        }

        public bool HasFlush()
        {
            Dictionary<Suit, int> data = [];
            foreach (Card card in Cards)
            {
                if (data.ContainsKey(card.Suit))
                    data[card.Suit] += 1;
                else
                    data[card.Suit] = 1;
            }

            foreach (int datum in data.Values)
                if (datum >= 5)
                    return true;
            return false;
        }

        public bool HasStraight()
        {
            var temp_Cards = new List<Card>(Cards);
            temp_Cards.Sort();
            int count = 0;
            var l_card = temp_Cards[0];
            foreach (Card r_card in temp_Cards)
            { 
                if ((r_card.Value - l_card.Value) == 1)
                    count += 1;
                else if ((r_card.Value - l_card.Value) > 1)
                    count = 0;

                if (count >= 4)
                    return true;
                l_card = r_card;
            }
            return false;
        }

        public bool HasStraightFlush()
        {
            return HasStraight() && HasFlush();
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

            return this == (Hand)obj;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Hand? other)
        {
            ArgumentNullException.ThrowIfNull(other);
            if (this == other) return 0;
            return (this > other) ? 1 : -1;
        }
    }
}