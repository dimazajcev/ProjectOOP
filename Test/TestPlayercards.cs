using ProjectOOP.Logic;
namespace Test
{
    [TestClass]
    public class TestPlayercards
    {
        [TestMethod]
        public void TestCountLower()
        {
            Deck deck = new Deck();
            Playercards playercards = new Playercards(-1, deck.deck);
            int expected = 0;
            int actual = playercards.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCountUpper()
        {
            Deck deck = new Deck();
            Playercards playercards = new Playercards(36, deck.deck);
            int expected = 0;
            int actual = playercards.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCountNormal()
        {
            Deck deck = new Deck();
            Playercards playercards = new Playercards(6, deck.deck);
            int expected = 6;
            int actual = playercards.Count;
            Assert.AreEqual(actual, expected);
        }
    }
}