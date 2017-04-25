using MonopolyEngine;
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
        public void TwoPlayers_GetOrder()
        {
            var p1 = new Player("Rossy", GameAvatar.Dog);
            var p2 = new Player("Luis", GameAvatar.Cat);

            p1.ThrowDice();
            p2.ThrowDice();

            bool result = _game.SetPlayerOrder(p1, p2);

            Assert.IsTrue(result);
            CollectionAssert.IsNotEmpty(_game.PlayOrder);
            CollectionAssert.Contains(_game.PlayOrder, "Rossy");
            CollectionAssert.Contains(_game.PlayOrder, "Luis");
        }

    }
}
