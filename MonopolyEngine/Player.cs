using System;

namespace MonopolyEngine
{
    public class Player
    {
        public string Name { get; private set; }
        public GameAvatar Avatar { get; private set;}
        public IDice Dice { get; private set; }

        public Player(string name, GameAvatar avatar, IDice dice = null)
        {
            this.Name = name;
            this.Avatar = avatar;

            if(dice != null)
            {
                this.Dice = dice;
            }else
            {
                this.Dice = new Dice();
            }
            
        }

        public void ThrowDice()
        {
            this.Dice.ThrowDice();
        }
    }
}
