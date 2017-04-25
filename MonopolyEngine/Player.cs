using System;

namespace MonopolyEngine
{
    public class Player
    {
        public string Name { get; private set; }
        public GameAvatar Avatar { get; private set;}
        public Dice Dice { get; private set; }

        public Player(string name, GameAvatar avatar)
        {
            this.Name = name;
            this.Avatar = avatar;

            this.Dice = new Dice();
        }

        public void ThrowDice()
        {
            this.Dice.ThrowDice();
        }
    }
}
