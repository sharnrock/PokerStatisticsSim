using PokerSimConsole;

namespace Tests
{
    public class OnePairTest
    {
        [Test]
        public void test_true_when_one_pair()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Heart, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(12));
            c.Turn = new Card(Suit.Spade, new CardValue(10));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);

            var result = h.has_one_pair();

            Assert.That(result, Is.True);
        }

        [Test]
        public void test_false_when_two_pair()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(12)),
                Turn = new Card(Suit.Spade, new CardValue(12)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.IsFalse(h.has_one_pair());
        }

        [Test]
        public void test_false_when_zero_pair()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(12));
            c.Flop3 = new Card(Suit.Spade, new CardValue(11));
            c.Turn = new Card(Suit.Spade, new CardValue(10));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.IsFalse(h.has_one_pair());
        }

        [Test]
        public void test_false_when_3ofakind()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(13));
            c.Turn = new Card(Suit.Spade, new CardValue(10));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.IsFalse(h.has_one_pair());
        }
    }

    internal class TwoPairTest
    {
        [Test]
        public void test_true_when_two_pair()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(12));
            c.Turn = new Card(Suit.Spade, new CardValue(12));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.IsTrue(h.has_two_pair());
        }

        [Test]
        public void test_false_when_one_pair()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(12));
            c.Turn = new Card(Suit.Spade, new CardValue(2));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.IsFalse(h.has_two_pair());
        }

        [Test]
        public void test_false_when_3ofakind()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(13));
            c.Turn = new Card(Suit.Spade, new CardValue(10));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.IsFalse(h.has_two_pair());
        }
    }

    internal class ThreeOfaKindTest
    {
        [Test]
        public void test_true_when_3_match()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(12));
            c.Turn = new Card(Suit.Spade, new CardValue(2));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var h = new Hand(new Card(Suit.Spade, new CardValue(13)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.IsTrue(h.has_three_ofa_kind());
        }

        [Test]
        public void test_false_when_3_pairs()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(12));
            c.Turn = new Card(Suit.Spade, new CardValue(12));
            c.River = new Card(Suit.Spade, new CardValue(11));
            var h = new Hand(new Card(Suit.Spade, new CardValue(11)), new Card(Suit.Spade, new CardValue(2)), c);
            Assert.IsFalse(h.has_three_ofa_kind());
        }

        [Test]
        public void test_false_when_4_ofa_kind()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(13));
            c.Turn = new Card(Suit.Spade, new CardValue(13));
            c.River = new Card(Suit.Spade, new CardValue(8));
            var h = new Hand(new Card(Suit.Spade, new CardValue(9)), new Card(Suit.Spade, new CardValue(10)), c);
            Assert.IsFalse(h.has_three_ofa_kind());
        }
    }

    internal class FullHouseTest
    {
        [Test]
        public void test_true_when_fullhouse()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(13));
            c.Turn = new Card(Suit.Spade, new CardValue(12));
            c.River = new Card(Suit.Spade, new CardValue(12));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.IsTrue(h.has_full_house());
        }

        [Test]
        public void test_true_when_fullhouse_and_extra_match()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(13));
            c.Turn = new Card(Suit.Spade, new CardValue(12));
            c.River = new Card(Suit.Spade, new CardValue(12));
            var h = new Hand(new Card(Suit.Spade, new CardValue(12)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.IsTrue(h.has_full_house());
        }

        [Test]
        public void test_false_when_3_ofa_kind()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(13));
            c.Turn = new Card(Suit.Spade, new CardValue(10));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.IsTrue(h.has_full_house());
        }
    }

    public class FourOfaKindTest
    {
        [Test]
        public void test_true_when_4_ofa_kind()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(13));
            c.Turn = new Card(Suit.Spade, new CardValue(13));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.IsTrue(h.has_4_ofa_kind());
        }

        [Test]
        public void test_true_when_4_ofa_kind_spread()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(11));
            c.Flop3 = new Card(Suit.Spade, new CardValue(13));
            c.Turn = new Card(Suit.Spade, new CardValue(14));
            c.River = new Card(Suit.Spade, new CardValue(13));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(13)), c);
            Assert.IsTrue(h.has_4_ofa_kind());
        }
    }

    internal class FlushTest
    {
        [Test]
        public void test_true_when_5card_flush()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(13));
            c.Turn = new Card(Suit.Spade, new CardValue(13));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var h = new Hand(new Card(Suit.Heart, new CardValue(8)), new Card(Suit.Heart, new CardValue(7)), c);
            Assert.IsTrue(h.has_flush());
        }

        [Test]
        public void test_true_when_6card_flush()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(13));
            c.Turn = new Card(Suit.Spade, new CardValue(13));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Heart, new CardValue(7)), c);
            Assert.IsTrue(h.has_flush());
        }

        [Test]
        public void test_false_when_4card_flush()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(13));
            c.Flop2 = new Card(Suit.Spade, new CardValue(13));
            c.Flop3 = new Card(Suit.Spade, new CardValue(13));
            c.Turn = new Card(Suit.Spade, new CardValue(13));
            c.River = new Card(Suit.Heart, new CardValue(9));
            var h = new Hand(new Card(Suit.Heart, new CardValue(8)), new Card(Suit.Heart, new CardValue(7)), c);
            Assert.IsFalse(h.has_flush());
        }
    }

    internal class StraightTest
    {
        [Test]
        public void test_true_when_sequence()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(6));
            c.Flop2 = new Card(Suit.Spade, new CardValue(3));
            c.Flop3 = new Card(Suit.Spade, new CardValue(4));
            c.Turn = new Card(Suit.Spade, new CardValue(5));
            c.River = new Card(Suit.Spade, new CardValue(2));
            var h = new Hand(new Card(Suit.Spade, new CardValue(13)), new Card(Suit.Spade, new CardValue(13)), c);
            Assert.IsTrue(h.has_straight());
        }

        [Test]
        public void test_true_when_sequence_with_duplicates()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(2));
            c.Flop2 = new Card(Suit.Spade, new CardValue(3));
            c.Flop3 = new Card(Suit.Spade, new CardValue(4));
            c.Turn = new Card(Suit.Spade, new CardValue(4));
            c.River = new Card(Suit.Spade, new CardValue(5));
            var h = new Hand(new Card(Suit.Spade, new CardValue(6)), new Card(Suit.Spade, new CardValue(13)), c);
            Assert.IsTrue(h.has_straight());
        }

        [Test]
        public void test_false_when_no_sequence()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(2));
            c.Flop2 = new Card(Suit.Spade, new CardValue(3));
            c.Flop3 = new Card(Suit.Spade, new CardValue(4));
            c.Turn = new Card(Suit.Spade, new CardValue(6));
            c.River = new Card(Suit.Spade, new CardValue(7));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(13)), c);
            Assert.IsFalse(h.has_straight());
        }
    }

    internal class StraightFlushTest
    {
        [Test]
        public void test_false_when_no_sequence()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Spade, new CardValue(2));
            c.Flop2 = new Card(Suit.Spade, new CardValue(3));
            c.Flop3 = new Card(Suit.Spade, new CardValue(4));
            c.Turn = new Card(Suit.Spade, new CardValue(6));
            c.River = new Card(Suit.Spade, new CardValue(7));
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(13)), c);
            Assert.IsFalse(h.has_straight());
        }
    }

    internal class HardRankings
    {
        [Test]
        public void test_straight_flush_beats_four_of_a_kind()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Club, new CardValue(2));
            c.Flop2 = new Card(Suit.Spade, new CardValue(2));
            c.Flop3 = new Card(Suit.Spade, new CardValue(5));
            c.Turn = new Card(Suit.Spade, new CardValue(6));
            c.River = new Card(Suit.Spade, new CardValue(7));
            var winner = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(9)), c);
            var loser = new Hand(new Card(Suit.Heart, new CardValue(2)), new Card(Suit.Diamond, new CardValue(2)), c);

            Assert.IsTrue(winner.get_hand_rank() == HandRank.StraightFlush);
            Assert.IsTrue(loser.get_hand_rank() == HandRank.FourOfaKind);

            Assert.IsTrue(winner > loser);
            Assert.IsTrue(winner >= loser);
            Assert.IsTrue(loser < winner);
            Assert.IsTrue(loser <= winner);
            Assert.AreNotEqual(winner, loser);
            
            Assert.AreEqual(winner.get_high_card(), new Card(Suit.Spade, new CardValue(9)));
            Assert.AreEqual(loser.get_high_card(), new Card(Suit.Spade, new CardValue(7)));
        }

        [Test]
        public void test_high_cards_when_straight_flush_beats_four_of_a_kind()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Club, new CardValue(2));
            c.Flop2 = new Card(Suit.Spade, new CardValue(2));
            c.Flop3 = new Card(Suit.Spade, new CardValue(5));
            c.Turn = new Card(Suit.Spade, new CardValue(6));
            c.River = new Card(Suit.Spade, new CardValue(7));
            var winner = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(9)), c);
            var loser = new Hand(new Card(Suit.Heart, new CardValue(2)), new Card(Suit.Diamond, new CardValue(2)), c);

            Assert.AreEqual(winner.get_high_card(), new Card(Suit.Spade, new CardValue(9)));
            Assert.AreEqual(loser.get_high_card(), new Card(Suit.Spade, new CardValue(7)));
        }

        [Test]
        public void test_4_ofa_kind_beats_full_house()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Club, new CardValue(2));
            c.Flop2 = new Card(Suit.Spade, new CardValue(2));
            c.Flop3 = new Card(Suit.Spade, new CardValue(5));
            c.Turn = new Card(Suit.Spade, new CardValue(6));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var winner = new Hand(new Card(Suit.Heart, new CardValue(2)), new Card(Suit.Diamond, new CardValue(2)), c);
            var loser = new Hand(new Card(Suit.Spade, new CardValue(9)), new Card(Suit.Spade, new CardValue(9)), c);

            Assert.IsTrue(winner.get_hand_rank() == HandRank.FourOfaKind);
            Assert.IsTrue(loser.get_hand_rank() == HandRank.FullHouse);

            Assert.IsTrue(winner > loser);
            Assert.IsTrue(winner >= loser);
            Assert.IsTrue(loser < winner);
            Assert.IsTrue(loser <= winner);
            Assert.AreNotEqual(winner, loser);
        }

        [Test]
        public void test_full_house_beats_flush()
        {
            var c = new CommunityCards();
            c.Flop1 = new Card(Suit.Club, new CardValue(2));
            c.Flop2 = new Card(Suit.Spade, new CardValue(2));
            c.Flop3 = new Card(Suit.Spade, new CardValue(5));
            c.Turn = new Card(Suit.Spade, new CardValue(6));
            c.River = new Card(Suit.Spade, new CardValue(9));
            var winner = new Hand(new Card(Suit.Diamond, new CardValue(9)), new Card(Suit.Heart, new CardValue(9)), c);
            var loser = new Hand(new Card(Suit.Spade, new CardValue(4)), new Card(Suit.Spade, new CardValue(8)), c);

            Assert.IsTrue(winner.get_hand_rank() == HandRank.FullHouse);
            Assert.IsTrue(loser.get_hand_rank() == HandRank.Flush);

            Assert.IsTrue(winner > loser);
            Assert.IsTrue(winner >= loser);
            Assert.IsTrue(loser < winner);
            Assert.IsTrue(loser <= winner);
            Assert.AreNotEqual(winner, loser);
        }
    }
}