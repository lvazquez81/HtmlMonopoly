using MonopolyEngine;
using Moq;
using NUnit.Framework;

namespace MonopolyEngineTests
{
    [TestFixture]
    public class PlayerOrderTests
    {
        MonopolyGame _game;

        [SetUp]
        public void TestSetup()
        {
            _game = new MonopolyGame();
        }

        [Test]
        public void TwoPlayers_haveDifferentDiceResult_providesPlayerOrder()
        {
            var p1Dice = new Mock<IDice>();
            p1Dice.Setup(x => x.DiceOne).Returns(1);
            p1Dice.Setup(x => x.DiceTwo).Returns(2);
            var p1 = new Player("Rossy", GameAvatar.Dog, p1Dice.Object);

            var p2Dice = new Mock<IDice>();
            p2Dice.Setup(x => x.DiceOne).Returns(3);
            p2Dice.Setup(x => x.DiceTwo).Returns(4);
            var p2 = new Player("Luis", GameAvatar.Cat, p2Dice.Object);

            p1.ThrowDice();
            p2.ThrowDice();

            bool result = _game.SetPlayerOrder(p1, p2);

            Assert.IsTrue(result);
            CollectionAssert.IsNotEmpty(_game.PlayOrder);
            CollectionAssert.Contains(_game.PlayOrder, "Rossy");
            CollectionAssert.Contains(_game.PlayOrder, "Luis");
        }

        [Test]
        public void TwoPlayers_haveSameDiceResult_noOrderIsProvided()
        {
            var p1Dice = new Mock<IDice>();
            p1Dice.Setup(x => x.DiceOne).Returns(1);
            p1Dice.Setup(x => x.DiceTwo).Returns(2);
            var p1 = new Player("Rossy", GameAvatar.Dog, p1Dice.Object);

            var p2Dice = new Mock<IDice>();
            p2Dice.Setup(x => x.DiceOne).Returns(1);
            p2Dice.Setup(x => x.DiceTwo).Returns(2);
            var p2 = new Player("Luis", GameAvatar.Cat, p2Dice.Object);
            p1.ThrowDice();
            p2.ThrowDice();

            bool result = _game.SetPlayerOrder(p1, p2);

            Assert.IsFalse(result);
            CollectionAssert.IsEmpty(_game.PlayOrder);
        }

    }
}
