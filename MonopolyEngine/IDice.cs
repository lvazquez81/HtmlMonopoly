using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyEngine
{
    public interface IDice
    {
        void ThrowDice();
        int DiceOne { get; }
        int DiceTwo { get; }
    }
}
