using ProjectOOP.Logic;
namespace Test
{
    [TestClass]
    public class TestGame
    {
        [TestMethod]
        public void TestListLower()
        {
            List<Player> list = new List<Player>();
            {
                Player player1 = new Player(1, 6);
            };
            Game game = new Game(1, list);
            Assert.ThrowsException<ArgumentException>(() => game);
        }
        [TestMethod]
        public void TestListUpper()
        {
            List<Player> list = new List<Player>();
            {
                Player player1 = new Player(1, 6);
                Player player2 = new Player(2, 6);
                Player player3 = new Player(3, 6);
                Player player4 = new Player(4, 6);
                Player player5 = new Player(5, 6);
                Player player6 = new Player(6, 6);
                Player player7 = new Player(7, 6);
            };
            Game game = new Game(1, list);
            Assert.ThrowsException<ArgumentException>(() => game);
        }
        [TestMethod]
        public void TestListNormal()
        {
            List<Player> list = new List<Player>();
            {
                Player player1 = new Player(1, 6);
                Player player2 = new Player(2, 6);
            };
            Game game = new Game(1, list);
            int expected = 2;
            int actual = game.Count;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestIdLower()
        {
            List<Player> list = new List<Player>();
            {
                Player player1 = new Player(1, 6);
                Player player2 = new Player(2, 6);
            };
            Game game = new Game(-1, list);
            Assert.ThrowsException<ArgumentException>(() => game);
        }
        [TestMethod]
        public void TestIdNormal()
        {
            List<Player> list = new List<Player>();
            {
                Player player1 = new Player(1, 6);
                Player player2 = new Player(2, 6);
            };
            Game game = new Game(1, list);
            int expected = 1;
            int actual = game.Id;
            Assert.AreEqual(actual, expected);
        }
    }
}