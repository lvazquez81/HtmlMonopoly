using MonopolyEngine;
using NUnit.Framework;

namespace MonopolyEngineTests
{
    [TestFixture]
    public class AddPlayerTests
    {
        MonopolyGame _game;

        [SetUp]
        public void TestSetup()
        {
            _game = new MonopolyGame();
        }

        [Test]
        public void AddPlayerWithNameAndAvatar()
        {
            _game.Players.Save(name: "Rossy", avatar: GameAvatar.Dog);

            Assert.IsTrue(_game.Players.Has("Rossy"));
            Assert.AreEqual(GameAvatar.Dog, _game.Players.Get("Rossy").Avatar);
        }

        [Test]
        public void AddPlayerWithNoName()
        {
            _game.Players.Save(name: "", avatar: GameAvatar.Dog);

            CollectionAssert.IsNotEmpty(_game.Players.Names);
            Assert.IsFalse(string.IsNullOrWhiteSpace(_game.Players.Names[0]));
        }

        [Test]
        public void AddSecondPlayer()
        {
            _game.Players.Save(name: "Rossy", avatar: GameAvatar.Dog);
            _game.Players.Save(name: "Luis", avatar: GameAvatar.Cat);

            CollectionAssert.Contains(_game.Players.Names, "Rossy");
            CollectionAssert.Contains(_game.Players.Names, "Luis");
        }

        [Test]
        public void AddSecondPlayerWithSameName()
        {
            _game.Players.Save(name: "Rossy", avatar: GameAvatar.Dog);
            _game.Players.Save(name: "Rossy", avatar: GameAvatar.Cat);

            Assert.IsTrue(_game.Players.Count == 1);
            CollectionAssert.Contains(_game.Players.Names, "Rossy");
        }

        [Test]
        public void AddSecondPlayerWithSameAvatar()
        {
            _game.Players.Save(name: "Rossy", avatar: GameAvatar.Dog);
            _game.Players.Save(name: "Luis", avatar: GameAvatar.Dog);

            Assert.IsTrue(_game.Players.Count == 1);
            CollectionAssert.Contains(_game.Players.Names, "Rossy");
        }

        [Test]
        public void AddSecondPlayerWithNoNameButSameAvatar()
        {
            _game.Players.Save(name: "Rossy", avatar: GameAvatar.Dog);
            _game.Players.Save(name: "", avatar: GameAvatar.Dog);

            Assert.IsTrue(_game.Players.Count == 1);
            CollectionAssert.Contains(_game.Players.Names, "Rossy");
        }

        [Test]
        public void RemovePlayer()
        {
            _game.Players.Save(name: "Rossy", avatar: GameAvatar.Dog);
            bool result = _game.Players.Remove(name: "Rossy");

            Assert.IsTrue(result);
            CollectionAssert.IsEmpty(_game.Players.Names);
        }
    }
}
