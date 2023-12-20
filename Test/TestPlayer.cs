using ProjectOOP.Logic;
namespace Test
{
    [TestClass]
    public class TestPlayer
    {
        [TestMethod]
        public void TestCountLower()
        {
            Player player = new Player(1, -1);
            Assert.ThrowsException<ArgumentException>(() => player);
        }
        [TestMethod]
        public void TestCountUpper()
        {
            Player player = new Player(1, 36);
            Assert.ThrowsException<ArgumentException>(() => player);
        }
        [TestMethod]
        public void TestCountNormal()
        {
            Player player = new Player(1, 6);
            int actual = player.Count;
            int expected = 6;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestIdLower()
        {
            Player player = new Player(-1, 6);
            Assert.ThrowsException<ArgumentException>(() => player);
        }
        [TestMethod]
        public void TestIdNormal()
        {
            Player player = new Player(1, 6);
            int actual = player.Id;
            int expected = 1;
            Assert.AreEqual(actual, expected);
        }
    }
}
