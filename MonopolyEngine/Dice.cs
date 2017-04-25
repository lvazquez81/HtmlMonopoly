using System;

namespace MonopolyEngine
{
    public class Dice
    {
        private readonly Random _rnd;
        public int DiceOne { get; private set; }
        public int DiceTwo { get; private set; }

        public bool IsDouble
        {
            get
            {
                return this.DiceOne == this.DiceTwo;
            }
        }

        public int TotalValue
        {
            get
            {
                return this.DiceOne + this.DiceTwo;
            }
        }

        public Dice()
        {
            _rnd = new Random(DateTime.Now.Millisecond);
        }

        public void ThrowDice()
        {
            this.DiceOne = _rnd.Next(1, 6);
            this.DiceTwo = _rnd.Next(1, 6);
        }
    }
}
