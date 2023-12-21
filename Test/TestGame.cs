using ProjectOOP.Logic;
namespace Test
{
    [TestClass]
    public class TestGame
    {
        [TestMethod]
        public void TestListLower()
        {
            Deck deck = new Deck();
            List<Player> list = new List<Player>();
            list.Add(new Player(1, 6, deck.deck));
            Game game = new Game(1, list, deck);
            int expected = 0;
            int actual = game.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestListUpper()
        {
            Deck deck = new Deck();
            List<Player> list = new List<Player>();
            list.Add(new Player(1, 6, deck.deck));
            list.Add(new Player(2, 6, deck.deck));
            list.Add(new Player(3, 6, deck.deck));
            list.Add(new Player(4, 6, deck.deck));
            list.Add(new Player(5, 6, deck.deck));
            list.Add(new Player(6, 6, deck.deck));
            list.Add(new Player(7, 6, deck.deck));
            Game game = new Game(1, list, deck);
            int expected = 0;
            int actual = game.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestListNormal()
        {
            Deck deck = new Deck();
            List<Player> list = new List<Player>();
            list.Add(new Player(1, 6, deck.deck));
            list.Add(new Player(2, 6, deck.deck));
            Game game = new Game(1, list, deck);
            int expected = 2;
            int actual = game.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestIdLower()
        {
            Deck deck = new Deck();
            List<Player> list = new List<Player>();
            list.Add(new Player(1, 6, deck.deck));
            list.Add(new Player(2, 6, deck.deck));
            Game game = new Game(-1, list, deck);
            int expected = 1;
            int actual = game.Id;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestIdNormal()
        {
            Deck deck = new Deck();
            List<Player> list = new List<Player>();
            {
                list.Add(new Player(1, 6, deck.deck));
                list.Add(new Player(2, 6, deck.deck));
            };
            Game game = new Game(1, list, deck);
            int expected = 1;
            int actual = game.Id;
            Assert.AreEqual(expected, actual);
        }
    }
}