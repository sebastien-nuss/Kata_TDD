using NUnit.Framework;

namespace Kata_TDD.Bowling.Test
{
    public class BowlingGameTest
    {
        private Game testGame;

        [SetUp]
        public void Setup()
        {
            testGame = new Game();
        }

        private void RollMany(int n, int pins)
        {
            for (int ii = 0; ii < n; ii++)
                testGame.Roll(pins);
        }

        public void RollSpare()
        {
            testGame.Roll(5);
            testGame.Roll(5);
        }

        public void RollStrike()
        {
            testGame.Roll(10);
        }

        [Test]
        public void TestGutterGame()
        {
            RollMany(20, 0);
            Assert.AreEqual(testGame.Score(), 0);
        }

        [Test]
        public void TestAllOneGame()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, testGame.Score());
        }

        [Test]
        public void TestOneSpare()
        {
            RollSpare();
            testGame.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, testGame.Score());
        }

        [Test]
        public void TestOneStrike()
        {
            RollStrike();
            testGame.Roll(3);
            testGame.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, testGame.Score());
        }

        [Test]
        public void TestPerfectGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, testGame.Score());
        }
    }
}