using ProjectOOP.Interfaces;
using ProjectOOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.Logic
{
    public class Game: Characteristics, IPrintable, IString, ICloneable
    {
        public int Id { get; set; } = 1;
        public int Count {  get; set; }
        public List<Player> player { get; set; }
        public List<Cards> list { get; set; }
        public Game(int id, List<Player> players, Deck deck) 
        {
            if (id > 0)
                Id = id;
            if (players.Count > 1 && players.Count <= 6)
                Count = players.Count;
            player = players;
            list = deck.deck;

        }
        public override string ToString()
        {
            return $"{Id} Game, Players {player.Count}, Deck {list.Count}";
        }
        public string PrintToDisplay()
        {
            Info info = new Info(player, list);
            return info.ToString();
        }
        public object Clone()
        {
            return list;
        }
    }
}
