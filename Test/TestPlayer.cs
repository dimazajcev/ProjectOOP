using ProjectOOP.Logic;
namespace Test
{
    [TestClass]
    public class TestPlayer
    {
        [TestMethod]
        public void TestCountLower()
        {
            Deck deck = new Deck();
            Player player = new Player(1, -1, deck.deck);
            int actual = player.Count;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCountUpper()
        {
            Deck deck = new Deck();
            Player player = new Player(1, 36, deck.deck);
            int actual = player.Count;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCountNormal()
        {
            Deck deck = new Deck();
            Player player = new Player(1, 6, deck.deck);
            int actual = player.Count;
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestIdLower()
        {
            Deck deck = new Deck();
            Player player = new Player(-1, 6, deck.deck);
            int actual = player.Id;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestIdNormal()
        {
            Deck deck = new Deck();
            Player player = new Player(1, 6, deck.deck);
            int actual = player.Id;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}
