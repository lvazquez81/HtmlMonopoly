using System.Collections.Generic;
using System.Linq;

namespace MonopolyEngine
{
    public class MonopolyGame
    {
        public PlayerRoster Players { get; private set; }

        public MonopolyGame()
        {
            this.Players = new PlayerRoster();
        }

        
    }
}
