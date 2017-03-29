using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyEngine
{
    public class Player
    {
        public string Name { get; }

        public ThrowResult ThrowDice()
        {
            return new ThrowResult()
            {
                DiceOne = 2,
                DiceTwo = 5
            };
        }
    }
}
