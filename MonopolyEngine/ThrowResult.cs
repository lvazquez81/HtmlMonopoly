using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyEngine
{
    public class ThrowResult
    {
        public int DiceOne { get; set; }
        public int DiceTwo { get; set; }

        public int Result
        {
            get
            {
                return this.DiceOne + this.DiceTwo;
            }
        }
    }
}
