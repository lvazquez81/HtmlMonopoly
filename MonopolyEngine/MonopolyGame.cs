using System;
using System.Collections.Generic;
using System.Linq;

namespace MonopolyEngine
{
    public class MonopolyGame
    {
        public PlayerRoster Players { get; private set; }
        public IList<string> PlayOrder { get; private set; }

        public MonopolyGame()
        {
            this.Players = new PlayerRoster();
            this.PlayOrder = new List<string>();
        }

        public bool SetPlayerOrder(Player p1, Player p2)
        {
            bool orderSet = false;

            int p1TotalValue = p1.Dice.DiceOne + p1.Dice.DiceTwo;
            int p2TotalValue = p2.Dice.DiceOne + p2.Dice.DiceTwo;

            if (p1TotalValue != p2TotalValue)
            {
                if (p1TotalValue > p2TotalValue)
                {
                    this.PlayOrder.Add(p1.Name);
                    this.PlayOrder.Add(p2.Name);
                }
                else
                {
                    this.PlayOrder.Add(p2.Name);
                    this.PlayOrder.Add(p1.Name);
                }

                orderSet = true;
            }

            return orderSet;

        }
    }
}
