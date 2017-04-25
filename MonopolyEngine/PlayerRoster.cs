using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyEngine
{
    public class PlayerRoster
    {
        private readonly IDictionary<string, Player> _players;

        public PlayerRoster()
        {
            _players = new Dictionary<string, Player>();
        }

        public void Save(string name, GameAvatar avatar)
        {
            if (!_players.Keys.Contains(name) && !AvatarIsTaken(avatar))
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    name = GeneratePlayerName();
                }

                var p = new Player(name, avatar);
                _players.Add(name, p);
            }
        }

        private bool AvatarIsTaken(GameAvatar avatar)
        {
            return (from x in _players
                    where x.Value.Avatar == avatar
                    select x).Count() > 0;
        }

        private string GeneratePlayerName()
        {
            return string.Format("P{0}", _players.Count + 1);
        }

        public bool Has(string name)
        {
            return _players.Keys.Contains(name);
        }

        public Player Get(string name)
        {
            if (this.Has(name))
            {
                return _players[name];
            }
            else
            {
                return null;
            }
        }

        public bool Remove(string name)
        {
            bool result = false;

            if (_players.Keys.Contains(name))
            {
                result = _players.Remove(name);
            }

            return result;
        }

        public IList<string> Names
        {
            get { return _players.Keys.ToList(); }
        }

        public int Count
        {
            get { return _players.Count; }
        }
    }
}
