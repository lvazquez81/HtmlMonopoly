namespace MonopolyEngine
{
    public class Player
    {
        public string Name { get; private set; }
        public GameAvatar Avatar { get; private set;}

        public Player(string name, GameAvatar avatar)
        {
            this.Name = name;
            this.Avatar = avatar;
        }
    }
}
