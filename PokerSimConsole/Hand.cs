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

    public class Hand
    {
        private List<Card> Cards { get; set; }

        public Hand(Card personal1, Card personal2, CommunityCards community)
        {
            Cards = new List<Card> { personal1, personal2, community.Flop1, community.Flop2, community.Flop3, community.Turn, community.River };
        }

        public HandRank get_hand_rank()
        {
            if (has_straight_flush())
                return HandRank.StraightFlush;
            else if (has_4_ofa_kind())
                return HandRank.FourOfaKind;
            else if (has_full_house())
                return HandRank.FullHouse;
            else if (has_flush())
                return HandRank.Flush;
            else if (has_straight())
                return HandRank.Straight;
            else if (has_three_ofa_kind())
                return HandRank.ThreeOfaKind;
            else if (has_two_pair())
                return HandRank.TwoPair;
            else if (has_one_pair())
                return HandRank.OnePair;
            else
                return HandRank.HighCard; // Default return
        }



        public Card? get_high_card()
        {
            return Cards.Max();
        }

        public static bool operator ==(Hand a, Hand b)
        {
            return (a.get_hand_rank() == b.get_hand_rank());
        }

        public static bool operator !=(Hand a, Hand b)
        {
            return (a.get_hand_rank() != b.get_hand_rank());
        }

        public static bool operator <(Hand a, Hand b)
        {
            return (a.get_hand_rank() < b.get_hand_rank());
        }

        public static bool operator >(Hand a, Hand b)
        {
            return (a.get_hand_rank() > b.get_hand_rank());
        }

        public static bool operator <=(Hand a, Hand b)
        {
            return (a.get_hand_rank() <= b.get_hand_rank());
        }

        public static bool operator >=(Hand a, Hand b)
        {
            return (a.get_hand_rank() >= b.get_hand_rank());
        }

        public int count_pair_matches()
        {
            var data = count_value_matches();
            int pairs = 0;
            foreach (int datum in data.Values)
                if (datum == 2)
                    pairs += 1;
            return pairs;

        }

        public bool has_one_pair()
        {
            return count_pair_matches() == 1;
        }

        public bool has_two_pair()
        {
            return count_pair_matches() == 2;
        }

        public bool has_three_ofa_kind()
        {
            var data = this.count_value_matches();
            foreach (int datum in data.Values)
                if (datum == 3)
                    return true;
            return false;
        }

        public bool has_full_house()
        {
            if (!has_three_ofa_kind())
                return false;
            var data = this.count_value_matches();
            foreach (int datum in data.Values)
                if (datum > 1)
                    return true;
            return false;
        }

        public bool has_4_ofa_kind()
        {
            var data = this.count_value_matches();
            foreach (int datum in data.Values)
                if (datum == 4)
                    return true;
            return false;
        }

        public Dictionary<CardValue, int> count_value_matches()
        {
            Dictionary<CardValue, int> data = [];
            foreach (Card card in Cards)
            {
                if (data.Keys.Contains(card.Value))
                    data[card.Value] += 1;
                else
                    data[card.Value] = 1;
            }
            return data;
        }

        public bool has_flush()
        {
            Dictionary<Suit, int> data = [];
            foreach (Card card in Cards)
            {
                if (data.Keys.Contains(card.Suit))
                    data[card.Suit] += 1;
                else
                    data[card.Suit] = 1;
            }

            foreach (int datum in data.Values)
                if (datum >= 5)
                    return true;
            return false;
        }

        public bool has_straight()
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

        public bool has_straight_flush()
        {
            return has_straight() && has_flush();
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
    }
}