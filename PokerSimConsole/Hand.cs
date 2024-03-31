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

        // Implement get_hand_rank and other methods as needed, converting Python logic to C#

        // Example of conversion:
        public HandRank GetHandRank()
        {
            // Implement logic to determine the hand rank, converting from Python's if-elif chain
            // Example:
            if (HasStraightFlush()) return HandRank.StraightFlush;
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

        private bool HasStraightFlush()
        {
            // Implement this method based on the Python logic
            return false; // Placeholder return
        }

        private Card get_high_card()
        {
            return new Card();
            //# TODO: get the kicker
            //return this.cards[0];
        }

        public static bool operator ==(Hand a, Hand b)
        {
            return false;
        }

        public static bool operator !=(Hand a, Hand b)
        {
            return false;
        }

        public static bool operator <(Hand a, Hand b)
        { return false; }

        public static bool operator >(Hand a, Hand b)
        { return false; }

        public static bool operator <=(Hand a, Hand b)
        { return false; }

        public static bool operator >=(Hand a, Hand b)
        { return false; }

        private int count_pair_matches()
        {
            //int data = this.count_value_matches()
            //int pairs = 0;
            //foreach (datum in data.values())
            //    if (datum == 2)
            //        pairs += 1;
            //return pairs;
            return 0;
        }

        private bool has_one_pair()
        {
            return false;
            //return this.count_pair_matches() == 1
        }

        private bool has_two_pair()
        {
            return false;
            //  return this.count_pair_matches() == 2
        }

        private bool has_three_ofa_kind()
        {
            //data = this.count_value_matches()
            //for datum in data.values():
            //    if datum == 3:
            //        return True
            return false;
        }

        private bool has_full_house()
        {
            //if not this.has_three_ofa_kind():
            //        return False
            //    data = this.count_value_matches()
            //    for datum in data.values():
            //        if datum > 1:
            //            return True
            return false;
        }

        private bool has_4_ofa_kind()
        {
            //data = this.count_value_matches()
            //    for datum in data.values():
            //        if datum == 4:
            //            return True
            return false;
        }

        private int count_value_matches()
        {
            //data = { }
            //for card in this.cards:
            //        if card.value in data.keys():
            //            data[card.value] += 1
            //        else:
            //            data[card.value] = 1
            //    return data
            return 0;
        }

        private bool has_flush()
        {
            //data = { }
            //for card in this.cards:
            //        if card.suit in data.keys():
            //            data[card.suit] += 1
            //        else:
            //            data[card.suit] = 1

            //    for datum in data.values():
            //        if datum >= 5:
            //            return True
            return false;
        }

        private bool has_straight()
        {
            //temp_cards = this.cards.copy()
            //    temp_cards.sort(key = value_to_int)

            //    count = 0
            //    l_card = temp_cards[0]
            //    for r_card in temp_cards[1:]:
            //        if value_to_int(r_card) - value_to_int(l_card) == 1:
            //            count += 1
            //        elif value_to_int(r_card) -value_to_int(l_card) > 1:
            //            count = 0

            //        if count >= 4:
            //            return True
            //        l_card = r_card
            return false;
        }

        private bool has_straight_flush()
        {
            //return this.has_straight() and this.has_flush()
            return false;
        }
    }
}