using PokerSimConsole;

namespace Tests
{
    public class OnePairTest
    {
        [Test]
        public void test_true_when_one_pair()
        {
            //c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "Q")
            //c.turn = Card(Suit.Spade, "10")
            //c.river = Card(Suit.Spade, "9")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "7"), c)
            //self.assertTrue(h.has_one_pair())
        }

        [Test]
        public void test_false_when_two_pair()
        {
            //c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "Q")
            //c.turn = Card(Suit.Spade, "Q")
            //c.river = Card(Suit.Spade, "9")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "7"), c)
            //self.assertFalse(h.has_one_pair())
        }

        [Test]
        public void test_false_when_zero_pair()
        {
            //    c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "Q")
            //c.flop_3 = Card(Suit.Spade, "J")
            //c.turn = Card(Suit.Spade, "10")
            //c.river = Card(Suit.Spade, "9")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "7"), c)
            //self.assertFalse(h.has_one_pair())
        }

        [Test]
        public void test_false_when_3ofakind()
        {
            //    c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "K")
            //c.turn = Card(Suit.Spade, "10")
            //c.river = Card(Suit.Spade, "9")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "7"), c)
            //self.assertFalse(h.has_one_pair())
        }
    }

    internal class TwoPairTest
    {
        [Test]
        public void test_true_when_two_pair()
        {
            //c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "Q")
            //c.turn = Card(Suit.Spade, "Q")
            //c.river = Card(Suit.Spade, "9")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "7"), c)
            //self.assertTrue(h.has_two_pair())
        }

        [Test]
        public void test_false_when_one_pair()
        {
            //        c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "Q")
            //c.turn = Card(Suit.Spade, "2")
            //c.river = Card(Suit.Spade, "9")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "7"), c)
            //self.assertFalse(h.has_two_pair())
        }

        [Test]
        public void test_false_when_3ofakind()
        {
            //        c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "K")
            //c.turn = Card(Suit.Spade, "10")
            //c.river = Card(Suit.Spade, "9")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "7"), c)
            //self.assertFalse(h.has_two_pair())
        }
    }

    internal class ThreeOfaKindTest
    {
        [Test]
        public void test_true_when_3_match()
        {
            //c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "Q")
            //c.turn = Card(Suit.Spade, "2")
            //c.river = Card(Suit.Spade, "9")
            //h = Hand(Card(Suit.Spade, "K"), Card(Suit.Spade, "7"), c)
            //self.assertTrue(h.has_three_ofa_kind())
        }

        [Test]
        public void test_false_when_3_pairs()
        {
            //            c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "Q")
            //c.turn = Card(Suit.Spade, "Q")
            //c.river = Card(Suit.Spade, "J")
            //h = Hand(Card(Suit.Spade, "J"), Card(Suit.Spade, "2"), c)
            //self.assertFalse(h.has_three_ofa_kind())
        }

        [Test]
        public void test_false_when_4_ofa_kind()
        {
            //            c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "K")
            //c.turn = Card(Suit.Spade, "K")
            //c.river = Card(Suit.Spade, "8")
            //h = Hand(Card(Suit.Spade, "9"), Card(Suit.Spade, "10"), c)
            //self.assertFalse(h.has_three_ofa_kind())
        }
    }

    internal class FullHouseTest
    {
        [Test]
        public void test_true_when_fullhouse()
        {
            //c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "K")
            //c.turn = Card(Suit.Spade, "Q")
            //c.river = Card(Suit.Spade, "Q")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "7"), c)
            //self.assertTrue(h.has_full_house())
        }

        [Test]
        public void test_true_when_fullhouse_and_extra_match()
        {
            //                c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "K")
            //c.turn = Card(Suit.Spade, "Q")
            //c.river = Card(Suit.Spade, "Q")
            //h = Hand(Card(Suit.Spade, "Q"), Card(Suit.Spade, "7"), c)
            //self.assertTrue(h.has_full_house())
        }

        [Test]
        public void test_false_when_3_ofa_kind()
        {
            //                c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "K")
            //c.turn = Card(Suit.Spade, "10")
            //c.river = Card(Suit.Spade, "9")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "7"), c)
            //self.assertTrue(h.has_full_house())
        }
    }

    public class FourOfaKindTest
    {
        [Test]
        public void test_true_when_4_ofa_kind()
        {
            //c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "K")
            //c.turn = Card(Suit.Spade, "K")
            //c.river = Card(Suit.Spade, "9")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "7"), c)
            //self.assertTrue(h.has_4_ofa_kind())
        }

        [Test]
        public void test_true_when_4_ofa_kind_spread()
        {
            //                    c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "J")
            //c.flop_3 = Card(Suit.Spade, "K")
            //c.turn = Card(Suit.Spade, "A")
            //c.river = Card(Suit.Spade, "K")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "K"), c)
            //self.assertTrue(h.has_4_ofa_kind())
        }
    }

    internal class FlushTest
    {
        [Test]
        public void test_true_when_5card_flush()
        {
            //c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "K")
            //c.turn = Card(Suit.Spade, "K")
            //c.river = Card(Suit.Spade, "9")
            //h = Hand(Card(Suit.Heart, "8"), Card(Suit.Heart, "7"), c)
            //self.assertTrue(h.has_flush())
        }

        [Test]
        public void test_true_when_6card_flush()
        {
            //                        c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "K")
            //c.turn = Card(Suit.Spade, "K")
            //c.river = Card(Suit.Spade, "9")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Heart, "7"), c)
            //self.assertTrue(h.has_flush())
        }

        [Test]
        public void test_false_when_4card_flush()
        {
            //                        c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "K")
            //c.flop_2 = Card(Suit.Spade, "K")
            //c.flop_3 = Card(Suit.Spade, "K")
            //c.turn = Card(Suit.Spade, "K")
            //c.river = Card(Suit.Heart, "9")
            //h = Hand(Card(Suit.Heart, "8"), Card(Suit.Heart, "7"), c)
            //self.assertFalse(h.has_flush())
        }
    }

    internal class StraightTest
    {
        [Test]
        public void test_true_when_sequence()
        {
            //c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "6")
            //c.flop_2 = Card(Suit.Spade, "3")
            //c.flop_3 = Card(Suit.Spade, "4")
            //c.turn = Card(Suit.Spade, "5")
            //c.river = Card(Suit.Spade, "2")
            //h = Hand(Card(Suit.Spade, "K"), Card(Suit.Spade, "K"), c)
            //self.assertTrue(h.has_straight())
        }

        [Test]
        public void test_true_when_sequence_with_duplicates()
        {
            //                            c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "2")
            //c.flop_2 = Card(Suit.Spade, "3")
            //c.flop_3 = Card(Suit.Spade, "4")
            //c.turn = Card(Suit.Spade, "4")
            //c.river = Card(Suit.Spade, "5")
            //h = Hand(Card(Suit.Spade, "6"), Card(Suit.Spade, "K"), c)
            //self.assertTrue(h.has_straight())
        }

        [Test]
        public void test_false_when_no_sequence()
        {
            //                            c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "2")
            //c.flop_2 = Card(Suit.Spade, "3")
            //c.flop_3 = Card(Suit.Spade, "4")
            //c.turn = Card(Suit.Spade, "6")
            //c.river = Card(Suit.Spade, "7")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "K"), c)
            //self.assertFalse(h.has_straight())
        }
    }

    internal class StraightFlushTest
    {
        [Test]
        public void test_false_when_no_sequence()
        {
            //c = CommunityCards()
            //c.flop_1 = Card(Suit.Spade, "2")
            //c.flop_2 = Card(Suit.Spade, "3")
            //c.flop_3 = Card(Suit.Spade, "4")
            //c.turn = Card(Suit.Spade, "6")
            //c.river = Card(Suit.Spade, "7")
            //h = Hand(Card(Suit.Spade, "8"), Card(Suit.Spa
        }
    }

    internal class HardRankings
    {
        [Test]
        public void test_straight_flush_beats_four_of_a_kind()
        {
            //                                c = CommunityCards()
            //                                c.flop_1 = Card(Suit.Club, "2")
            //                                c.flop_2 = Card(Suit.Spade, "2")
            //                                c.flop_3 = Card(Suit.Spade, "5")
            //                                c.turn = Card(Suit.Spade, "6")
            //                                c.river = Card(Suit.Spade, "7")
            //                                winner = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "9"), c)
            //                                loser = Hand(Card(Suit.Heart, "2"), Card(Suit.Diamond, "2"), c)

            //self.assertTrue(winner.get_hand_rank() == hand.StraightFlush)
            //                                self.assertTrue(loser.get_hand_rank() == hand.FourOfaKind)

            //self.assertGreater(winner, loser)
            //                                self.assertGreaterEqual(winner, loser)
            //                                self.assertLess(loser, winner)
            //                                self.assertLessEqual(loser, winner)
            //                                self.assertNotEqual(winner, loser)

            //self.assertEqual(winner.get_high_card() == Card(Suit.Spade, "9"))
            //                                self.assertEqual(loser.get_high_card() == Card(Suit.Spade, "7"))
        }

        [Test]
        public void test_high_cards_when_straight_flush_beats_four_of_a_kind()
        {
            //                                c = CommunityCards()
            //c.flop_1 = Card(Suit.Club, "2")
            //c.flop_2 = Card(Suit.Spade, "2")
            //c.flop_3 = Card(Suit.Spade, "5")
            //c.turn = Card(Suit.Spade, "6")
            //c.river = Card(Suit.Spade, "7")
            //winner = Hand(Card(Suit.Spade, "8"), Card(Suit.Spade, "9"), c)
            //loser = Hand(Card(Suit.Heart, "2"), Card(Suit.Diamond, "2"), c)

            //self.assertEqual(winner.get_high_card() == Card(Suit.Spade, "9"))
            //self.assertEqual(loser.get_high_card() == Card(Suit.Spade, "7"))
        }

        [Test]
        public void test_4_ofa_kind_beats_full_house()
        {
            //                                c = CommunityCards()
            //c.flop_1 = Card(Suit.Club, "2")
            //c.flop_2 = Card(Suit.Spade, "2")
            //c.flop_3 = Card(Suit.Spade, "5")
            //c.turn = Card(Suit.Spade, "6")
            //c.river = Card(Suit.Spade, "9")
            //winner = Hand(Card(Suit.Heart, "2"), Card(Suit.Diamond, "2"), c)
            //loser = Hand(Card(Suit.Spade, "9"), Card(Suit.Spade, "9"), c)

            //self.assertTrue(winner.get_hand_rank() == hand.FourOfaKind)
            //self.assertTrue(loser.get_hand_rank() == hand.FullHouse)

            //self.assertGreater(winner, loser)
            //self.assertGreaterEqual(winner, loser)
            //self.assertLess(loser, winner)
            //self.assertLessEqual(loser, winner)
            //self.assertNotEqual(winner, loser)
        }

        [Test]
        public void test_full_house_beats_flush()
        {
            //c = CommunityCards()
            //c.flop_1 = Card(Suit.Club, "2")
            //c.flop_2 = Card(Suit.Spade, "2")
            //c.flop_3 = Card(Suit.Spade, "5")
            //c.turn = Card(Suit.Spade, "6")
            //c.river = Card(Suit.Spade, "9")
            //winner = Hand(Card(Suit.Diamond, "9"), Card(Suit.Heart, "9"), c)
            //loser = Hand(Card(Suit.Spade, "4"), Card(Suit.Spade, "8"), c)

            //self.assertTrue(winner.get_hand_rank() == hand.FullHouse)
            //self.assertTrue(loser.get_hand_rank() == hand.Flush)

            //self.assertGreater(winner, loser)
            //self.assertGreaterEqual(winner, loser)
            //self.assertLess(loser, winner)
            //self.assertLessEqual(loser, winner)
            //self.assertNotEqual(winner, loser)
        }
    }
}