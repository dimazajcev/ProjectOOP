using ProjectOOP.Interfaces;
using ProjectOOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.Logic
{
    public delegate void PlayersChangedEventHandler(object sender, EventArgs e);
    public class Game: Characteristics, IPrintable, IString, ICloneable
    {
        private List<Player> players = new List<Player>();
        public int Id { get; set; } = 1;
        public int Count { get { if (players.Any()) return players.Count; return 0; } }
        public List<Player> Players
        {
            get { return players; }
            set
            {
                if (value.Count > 1 && value.Count <= 6)
                {
                    players = value;
                    OnPlayersChanged();
                }
            }
        }
        public List<Cards> list { get; set; }
        public Game(int id, List<Player> players, Deck deck) 
        {
            if (id > 0)
                Id = id;
            Players = players;
            list = deck.deck;

        }
        public event PlayersChangedEventHandler PlayersChanged;
        public event Action<Game> GameAction;
        protected virtual void OnPlayersChanged()
        {
            PlayersChanged?.Invoke(this, EventArgs.Empty);
            OnGameAction();
        }
        protected virtual void OnGameAction()
        {
            GameAction?.Invoke(this);
        }
        public override string ToString()
        {
            return $"{Id} Game, Players {Count}, Deck {list.Count}";
        }
        public string PrintToDisplay()
        {
            Info info = new Info(players, list);
            return info.ToString();
        }
        public object Clone()
        {
            return list;
        }
    }
}
