using PokerSimConsole;

namespace HandDetection
{
    public class HasOnePair
    {
        [Test]
        public void HasOnePair_When_TwoKingsAndTheRestDontMatch()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Heart, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.Queen)),
                Turn = new Card(Suit.Spade, new CardValue(10)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);

            var result = h.HasOnePair();

            Assert.That(result, Is.True);
        }

        [Test]
        public void False_When_TwoPair()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.Queen)),
                Turn = new Card(Suit.Spade, new CardValue(CardValue.Queen)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasOnePair(), Is.False);
        }

        [Test]
        public void False_When_ZeroPair()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.Queen)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.Jack)),
                Turn = new Card(Suit.Spade, new CardValue(10)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasOnePair(), Is.False);
        }

        [Test]
        public void False_When_3ofakind()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.King)),
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
        public void True_When_TwoPair()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.Queen)),
                Turn = new Card(Suit.Spade, new CardValue(CardValue.Queen)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasTwoPair(), Is.True);
        }

        [Test]
        public void False_When_OnePair()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.Queen)),
                Turn = new Card(Suit.Spade, new CardValue(2)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasTwoPair(), Is.False);
        }

        [Test]
        public void False_When_3OfAKind()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.King)),
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
        public void True_When_3Match()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.Queen)),
                Turn = new Card(Suit.Spade, new CardValue(2)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(CardValue.King)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasThreeOfaKind(), Is.True);
        }

        [Test]
        public void False_When_3Pairs()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.Queen)),
                Turn = new Card(Suit.Spade, new CardValue(CardValue.Queen)),
                River = new Card(Suit.Spade, new CardValue(CardValue.Jack))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(CardValue.Jack)), new Card(Suit.Spade, new CardValue(2)), c);
            Assert.That(h.HasThreeOfaKind(), Is.False);
        }

        [Test]
        public void False_When_4OfAKind()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Turn = new Card(Suit.Spade, new CardValue(CardValue.King)),
                River = new Card(Suit.Spade, new CardValue(8))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(9)), new Card(Suit.Spade, new CardValue(10)), c);
            Assert.That(h.HasThreeOfaKind(), Is.False);
        }
    }

    internal class FullHouseTest
    {
        [Test]
        public void HasFullHouse_When_3KingsAnd2Queens()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Heart, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Club, new CardValue(CardValue.King)),
                Turn = new Card(Suit.Spade, new CardValue(CardValue.Queen)),
                River = new Card(Suit.Heart, new CardValue(CardValue.Queen))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasFullHouse(), Is.True);
        }

        [Test]
        public void HasFullHouse_When_3KingsAnd3Queens()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Heart, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Club, new CardValue(CardValue.King)),
                Turn = new Card(Suit.Spade, new CardValue(CardValue.Queen)),
                River = new Card(Suit.Heart, new CardValue(CardValue.Queen))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(CardValue.Queen)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasFullHouse(), Is.True);
        }

        [Test]
        public void False_When_3OfAKind()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Turn = new Card(Suit.Spade, new CardValue(10)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.HasFullHouse(), Is.True);
        }
    }

    public class FourOfaKind
    {
        [Test]
        public void True_When_4OfaKind()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Turn = new Card(Suit.Spade, new CardValue(CardValue.King)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(7)), c);
            Assert.That(h.Has4OfaKind(), Is.True);
        }

        [Test]
        public void True_When_4OfaKindSpread()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.Jack)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Turn = new Card(Suit.Spade, new CardValue(CardValue.Ace)),
                River = new Card(Suit.Spade, new CardValue(CardValue.King))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(CardValue.King)), c);
            Assert.That(h.Has4OfaKind(), Is.True);
        }
    }

    internal class HasFlush
    {
        [Test]
        public void HasFlush_When_5cardFlush()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Turn = new Card(Suit.Spade, new CardValue(CardValue.King)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Heart, new CardValue(8)), new Card(Suit.Heart, new CardValue(7)), c);
            Assert.That(h.HasFlush(), Is.True);
        }

        [Test]
        public void HasFlush_When_6CardFlush()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Turn = new Card(Suit.Spade, new CardValue(CardValue.King)),
                River = new Card(Suit.Spade, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Heart, new CardValue(7)), c);
            Assert.That(h.HasFlush(), Is.True);
        }

        [Test]
        public void NoFlush_When_4CardFlush()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop2 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Flop3 = new Card(Suit.Spade, new CardValue(CardValue.King)),
                Turn = new Card(Suit.Spade, new CardValue(CardValue.King)),
                River = new Card(Suit.Heart, new CardValue(9))
            };
            var h = new Hand(new Card(Suit.Heart, new CardValue(8)), new Card(Suit.Heart, new CardValue(7)), c);
            Assert.That(h.HasFlush(), Is.False);
        }
    }

    internal class StraightTest
    {
        [Test]
        public void True_When_Sequence()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(6)),
                Flop2 = new Card(Suit.Spade, new CardValue(3)),
                Flop3 = new Card(Suit.Spade, new CardValue(4)),
                Turn = new Card(Suit.Spade, new CardValue(5)),
                River = new Card(Suit.Spade, new CardValue(2))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(CardValue.King)), new Card(Suit.Spade, new CardValue(CardValue.King)), c);
            Assert.That(h.HasStraight(), Is.True);
        }

        [Test]
        public void True_When_SequenceWithDuplicates()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(2)),
                Flop2 = new Card(Suit.Spade, new CardValue(3)),
                Flop3 = new Card(Suit.Spade, new CardValue(4)),
                Turn = new Card(Suit.Spade, new CardValue(4)),
                River = new Card(Suit.Spade, new CardValue(5))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(6)), new Card(Suit.Spade, new CardValue(CardValue.King)), c);
            Assert.That(h.HasStraight(), Is.True);
        }

        [Test]
        public void True_When_SequenceWithAceAsOne()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(2)),
                Flop2 = new Card(Suit.Spade, new CardValue(3)),
                Flop3 = new Card(Suit.Spade, new CardValue(4)),
                Turn = new Card(Suit.Spade, new CardValue(5)),
                River = new Card(Suit.Spade, new CardValue(CardValue.Ace))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(CardValue.Queen)), new Card(Suit.Spade, new CardValue(CardValue.King)), c);
            Assert.That(h.HasStraight(), Is.True);
        }

        [Test]
        public void False_When_NoSequence()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(2)),
                Flop2 = new Card(Suit.Spade, new CardValue(3)),
                Flop3 = new Card(Suit.Spade, new CardValue(4)),
                Turn = new Card(Suit.Spade, new CardValue(6)),
                River = new Card(Suit.Spade, new CardValue(7))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(CardValue.King)), c);
            Assert.That(h.HasStraight(), Is.False);
        }
    }

    internal class StraightFlushTest
    {
        [Test]
        public void False_When_NoSequence()
        {
            var c = new CommunityCards
            {
                Flop1 = new Card(Suit.Spade, new CardValue(2)),
                Flop2 = new Card(Suit.Spade, new CardValue(3)),
                Flop3 = new Card(Suit.Spade, new CardValue(4)),
                Turn = new Card(Suit.Spade, new CardValue(6)),
                River = new Card(Suit.Spade, new CardValue(7))
            };
            var h = new Hand(new Card(Suit.Spade, new CardValue(8)), new Card(Suit.Spade, new CardValue(CardValue.King)), c);
            Assert.That(h.HasStraight(), Is.False);
        }
    }
}
namespace HandRanking 
{ 
    internal class HardRankings
    {
        [Test]
        public void StraightFlushBeatsFourOfAKind()
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
        public void HighCardWins_When_StraightFlushBeatsFourOfAKind()
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
        public void FourOfAKindBeatsFullHouse()
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
        public void FullHouseBeatsFlush()
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