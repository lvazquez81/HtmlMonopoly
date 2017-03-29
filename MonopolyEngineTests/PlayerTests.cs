using System;
using NUnit.Framework;
using MonopolyEngine;

namespace MonopolyEngineTests
{
    [TestFixture]
    public class BasicMoveTests
    {
        [Test]
        public void ThrowDice()
        {
            var p = new Player();
            ThrowResult r = p.ThrowDice();

            Assert.IsTrue(r.Result > 0);
            Assert.IsTrue(r.DiceOne > 0);
            Assert.IsTrue(r.DiceTwo > 0);
            Assert.IsTrue(r.DiceOne + r.DiceTwo <= 12);
        }

        [Test]
        public void Move()
        {

        }
    }
}
