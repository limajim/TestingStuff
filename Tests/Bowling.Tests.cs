using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;


namespace Tests
{
    [TestClass]
    public class BowlingTests
    {
        private Game _game;

        [TestInitialize]
        public void InitializeTests()
        {
            _game = new Game();
        }


        [TestMethod]
        public void DoesGameExist()
        {
            Assert.IsNotNull(_game);
        }
        [TestMethod]
        public void Bowling_GutterGames_Returns_0()
        {
            var pins = 0;
            var numberOfRolls = 20;
            RollingMany(numberOfRolls, pins);
            Assert.AreEqual(0, _game.ScoreOfGame());

        }

        [TestMethod]
        public void Bowling_OnePinPerRoll_Returns_20()
        {

            var pins = 1;
            var numberOfRolls = 20;
            RollingMany(numberOfRolls, pins);

            Assert.AreEqual(20, _game.ScoreOfGame());

        }

        [TestMethod]
        public void Bowling_OneSpare_with_Three_Equals_Sixteen()
        {
            _game.Roll(5);
            _game.Roll(5);
            _game.Roll(3);
            RollingMany(17, 0);

            Assert.AreEqual(16, _game.ScoreOfGame());
        }

        [TestMethod]
        public void Bowling_OneStrike_with_Three_Equals_TwentyFour()
        {
            _game.Roll(10);
            _game.Roll(3);
            _game.Roll(4);
            RollingMany(16, 0);

            Assert.AreEqual(24, _game.ScoreOfGame());
        }

        [TestMethod]
        public void Bowling_PerfectGame_Equals_ThreeHundred()
        {
            RollingMany(12, 10);
            Assert.AreEqual(300, _game.ScoreOfGame());
        }


        private void RollingMany(int rolls, int pins)
        {
            for (int roll = 0; roll < rolls; roll++)
            {
                _game.Roll(pins);
            }
        }

     

    }
}
