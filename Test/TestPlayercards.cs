using ProjectOOP.Logic;
namespace Test
{
    [TestClass]
    public class TestPlayercards
    {
        [TestMethod]
        public void TestCountLower()
        {
            Playercards playercards = new Playercards(-1);
            Assert.ThrowsException<ArgumentException>(() => playercards);
        }
        [TestMethod]
        public void TestCountUpper()
        {
            Playercards playercards = new Playercards(36);
            Assert.ThrowsException<ArgumentException>(() => playercards);
        }
        [TestMethod]
        public void TestCountNormal()
        {
            Playercards playercards = new Playercards(6);
            int expected = 6;
            int actual = playercards.Count;
            Assert.AreEqual(actual, expected);
        }
    }
}