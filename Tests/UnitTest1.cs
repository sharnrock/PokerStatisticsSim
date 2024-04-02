using PokerSimConsole;

namespace Tests
{
    public class OnePairTest
    {
        [Test]
        public void TestTrueWhenOnePair()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Heart, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(12)),
                Turn = new Card(Suit.Spade, new CardValue(10)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);

            var result = h.HasOnePair();

            Assert.That(result, Is.True);
        }

        [Test]
        public void Test_false_when_two_pair()
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
            Assert.That(h.HasOnePair(), Is.False);
        }

        [Test]
        public void Test_false_when_zero_pair()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(12)),
                Flop3 = new Card(Suit.Spade, new CardValue(11)),
                Turn = new Card(Suit.Spade, new CardValue(10)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasOnePair(), Is.False);
        }

        [Test]
        public void Test_false_when_3ofakind()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(13)),
                Turn = new Card(Suit.Spade, new CardValue(10)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasOnePair(), Is.False);
        }
    }

    internal class TwoPairTest
    {
        [Test]
        public void Test_true_when_two_pair()
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
            Assert.That(h.HasTwoPair(), Is.True);
        }

        [Test]
        public void Test_false_when_one_pair()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(12)),
                Turn = new Card(Suit.Spade, new CardValue(2)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasTwoPair(), Is.False);
        }

        [Test]
        public void Test_false_when_3ofakind()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(13)),
                Turn = new Card(Suit.Spade, new CardValue(10)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasTwoPair(), Is.False);
        }
    }

    internal class ThreeOfaKindTest
    {
        [Test]
        public void Test_true_when_3_match()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(12)),
                Turn = new Card(Suit.Spade, new CardValue(2)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(13)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasThreeOfaKind(), Is.True);
        }

        [Test]
        public void Test_false_when_3_pairs()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(12)),
                Turn = new Card(Suit.Spade, new CardValue(12)),
                River = new Card(Suit.Spade, new CardValue(11))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(11)), new Card(Suit.Spade, new CardValue(2)), c);
            Assert.That(h.HasThreeOfaKind(), Is.False);
        }

        [Test]
        public void Test_false_when_4_ofa_kind()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(13)),
                Turn = new Card(Suit.Spade, new CardValue(13)),
                River = new Card(Suit.Spade, new CardValue(8))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(9)), new Card(Suit.Spade, new CardValue(10)), c);
            Assert.That(h.HasThreeOfaKind(), Is.False);
        }
    }

    internal class FullHouseTest
    {
        [Test]
        public void Test_true_when_fullhouse()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(13)),
                Turn = new Card(Suit.Spade, new CardValue(12)),
                River = new Card(Suit.Spade, new CardValue(12))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasFullHouse(), Is.True);
        }

        [Test]
        public void Test_true_when_fullhouse_and_extra_match()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(13)),
                Turn = new Card(Suit.Spade, new CardValue(12)),
                River = new Card(Suit.Spade, new CardValue(12))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(12)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasFullHouse(), Is.True);
        }

        [Test]
        public void Test_false_when_3_ofa_kind()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(13)),
                Turn = new Card(Suit.Spade, new CardValue(10)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasFullHouse(), Is.True);
        }
    }

    public class FourOfaKindTest
    {
        [Test]
        public void Test_true_when_4_ofa_kind()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(13)),
                Turn = new Card(Suit.Spade, new CardValue(13)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.Has4OfaKind(), Is.True);
        }

        [Test]
        public void Test_true_when_4_ofa_kind_spread()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(11)),
                Flop3 = new Card(Suit.Spade, new CardValue(13)),
                Turn = new Card(Suit.Spade, new CardValue(14)),
                River = new Card(Suit.Spade, new CardValue(13))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(13)), c);
            Assert.That(h.Has4OfaKind(), Is.True);
        }
    }

    internal class FlushTest
    {
        [Test]
        public void Test_true_when_5card_flush()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(13)),
                Turn = new Card(Suit.Spade, new CardValue(13)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Heart, new CardValue(8)), new Card(Suit.Heart, new CardValue(7)), c);
            Assert.That(h.HasFlush(), Is.True);
        }

        [Test]
        public void Test_true_when_6card_flush()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(13)),
                Turn = new Card(Suit.Spade, new CardValue(13)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Heart, new CardValue(7)), c);
            Assert.That(h.HasFlush(), Is.True);
        }

        [Test]
        public void Test_false_when_4card_flush()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(13)),
                Flop2 = new Card(Suit.Spade, new CardValue(13)),
                Flop3 = new Card(Suit.Spade, new CardValue(13)),
                Turn = new Card(Suit.Spade, new CardValue(13)),
                River = new Card(Suit.Heart, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Heart, new CardValue(8)), new Card(Suit.Heart, new CardValue(7)), c);
            Assert.That(h.HasFlush(), Is.False);
        }
    }

    internal class StraightTest
    {
        [Test]
        public void Test_true_when_sequence()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(6)),
                Flop2 = new Card(Suit.Spade, new CardValue(3)),
                Flop3 = new Card(Suit.Spade, new CardValue(4)),
                Turn = new Card(Suit.Spade, new CardValue(5)),
                River = new Card(Suit.Spade, new CardValue(2))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(13)), new Card(Suit.Spade, new CardValue(13)), c);
            Assert.That(h.HasStraight(), Is.True);
        }

        [Test]
        public void Test_true_when_sequence_with_duplicates()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(2)),
                Flop2 = new Card(Suit.Spade, new CardValue(3)),
                Flop3 = new Card(Suit.Spade, new CardValue(4)),
                Turn = new Card(Suit.Spade, new CardValue(4)),
                River = new Card(Suit.Spade, new CardValue(5))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(6)), new Card(Suit.Spade, new CardValue(13)), c);
            Assert.That(h.HasStraight(), Is.True);
        }

        [Test]
        public void Test_false_when_no_sequence()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(2)),
                Flop2 = new Card(Suit.Spade, new CardValue(3)),
                Flop3 = new Card(Suit.Spade, new CardValue(4)),
                Turn = new Card(Suit.Spade, new CardValue(6)),
                River = new Card(Suit.Spade, new CardValue(7))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(13)), c);
            Assert.That(h.HasStraight(), Is.False);
        }
    }

    internal class StraightFlushTest
    {
        [Test]
        public void Test_false_when_no_sequence()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(2)),
                Flop2 = new Card(Suit.Spade, new CardValue(3)),
                Flop3 = new Card(Suit.Spade, new CardValue(4)),
                Turn = new Card(Suit.Spade, new CardValue(6)),
                River = new Card(Suit.Spade, new CardValue(7))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(13)), c);
            Assert.That(h.HasStraight(), Is.False);
        }
    }

    internal class HardRankings
    {
        [Test]
        public void Test_straight_flush_beats_four_of_a_kind()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Club, new CardValue(2)),
                Flop2 = new Card(Suit.Spade, new CardValue(2)),
                Flop3 = new Card(Suit.Spade, new CardValue(5)),
                Turn = new Card(Suit.Spade, new CardValue(6)),
                River = new Card(Suit.Spade, new CardValue(7))
            };
            var winner = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(9)), c);
            var loser = new Hand(new Card(Suit.Heart, new CardValue(2)), new Card(Suit.Diamond, new CardValue(2)), c);
            Assert.Multiple(() =>
            {
                Assert.That(winner.GetHandRank(), Is.EqualTo(HandRank.StraightFlush));
                Assert.That(loser.GetHandRank(), Is.EqualTo(HandRank.FourOfaKind));

                Assert.That(winner, Is.GreaterThan(loser));
                Assert.That(winner, Is.GreaterThanOrEqualTo(loser));
                Assert.That(loser, Is.LessThan(winner));
                Assert.That(loser, Is.LessThanOrEqualTo(winner));
                Assert.That(loser, Is.Not.EqualTo(winner));
                Assert.That(new Card(Suit.Spade, new CardValue(9)), Is.EqualTo(winner.GetHighCard()));
                Assert.That(new Card(Suit.Spade, new CardValue(7)), Is.EqualTo(loser.GetHighCard()));
            });
        }

        [Test]
        public void Test_high_cards_when_straight_flush_beats_four_of_a_kind()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Club, new CardValue(2)),
                Flop2 = new Card(Suit.Spade, new CardValue(2)),
                Flop3 = new Card(Suit.Spade, new CardValue(5)),
                Turn = new Card(Suit.Spade, new CardValue(6)),
                River = new Card(Suit.Spade, new CardValue(7))
            };
            var winner = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(9)), c);
            var loser = new Hand(new Card(Suit.Heart, new CardValue(2)), new Card(Suit.Diamond, new CardValue(2)), c);
            Assert.Multiple(() =>
            {
                Assert.That(new Card(Suit.Spade, new CardValue(9)), Is.EqualTo(winner.GetHighCard()));
                Assert.That(new Card(Suit.Spade, new CardValue(7)), Is.EqualTo(loser.GetHighCard()));
            });
        }

        [Test]
        public void Test_4_ofa_kind_beats_full_house()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Club, new CardValue(2)),
                Flop2 = new Card(Suit.Spade, new CardValue(2)),
                Flop3 = new Card(Suit.Spade, new CardValue(5)),
                Turn = new Card(Suit.Spade, new CardValue(6)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var winner = new Hand(new Card(Suit.Heart, new CardValue(2)), new Card(Suit.Diamond, new CardValue(2)), c);
            var loser = new Hand(new Card(Suit.Spade, new CardValue(9)), new Card(Suit.Spade, new CardValue(9)), c);
            Assert.Multiple(() =>
            {
                Assert.That(winner.GetHandRank(), Is.EqualTo(HandRank.FourOfaKind));
                Assert.That(loser.GetHandRank(), Is.EqualTo(HandRank.FullHouse));

                Assert.That(winner, Is.GreaterThan(loser));
                Assert.That(winner, Is.GreaterThanOrEqualTo(loser));
                Assert.That(loser, Is.LessThan(winner));
                Assert.That(loser, Is.LessThanOrEqualTo(winner));
                Assert.That(loser, Is.Not.EqualTo(winner));
            });
        }

        [Test]
        public void Test_full_house_beats_flush()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Club, new CardValue(2)),
                Flop2 = new Card(Suit.Spade, new CardValue(2)),
                Flop3 = new Card(Suit.Spade, new CardValue(5)),
                Turn = new Card(Suit.Spade, new CardValue(6)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var winner = new Hand(new Card(Suit.Diamond, new CardValue(9)), new Card(Suit.Heart, new CardValue(9)), c);
            var loser = new Hand(new Card(Suit.Spade, new CardValue(4)), new Card(Suit.Spade, new CardValue(8)), c);
            Assert.Multiple(() =>
            {
                Assert.That(winner.GetHandRank(), Is.EqualTo(HandRank.FullHouse));
                Assert.That(loser.GetHandRank(), Is.EqualTo(HandRank.Flush));

                Assert.That(winner, Is.GreaterThan(loser));
                Assert.That(winner, Is.GreaterThanOrEqualTo(loser));
                Assert.That(loser, Is.LessThan(winner));
                Assert.That(loser, Is.LessThanOrEqualTo(winner));
                Assert.That(loser, Is.Not.EqualTo(winner));
            });
        }
    }
}