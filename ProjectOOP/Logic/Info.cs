using ProjectOOP.Enums;
using ProjectOOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.Logic
{
    public class Info: IString
    {
        List<Player> Players;
        List<Cards> Deck;
        public Info(List<Player> players, List<Cards> deck)
        {
            Players = players;
            Deck = deck;
        }
        public override string ToString()
        {
            string result = string.Empty;
            foreach (Player p in Players)
            {
                result += p.ToString();
            }
            return $"{result}\n\nDeck: {Deck.Count}";
        }
    }
}
