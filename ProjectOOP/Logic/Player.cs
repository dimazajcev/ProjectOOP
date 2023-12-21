using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP.Enums;
using ProjectOOP.Interfaces;

namespace ProjectOOP.Logic
{
    public class Player: Characteristics, IString
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public List<Cards> list { get; set; }
        public Player(int id, int cards, List<Cards> deck) 
        {
            if (id > 0) 
                Id = id; 
            if (cards > 0 && cards < 36)
            {
                Count = cards;
                Playercards playercards = new Playercards(cards, deck);
                list = playercards.Cardsplayer;
            }
        }
        public override string ToString()
        {
            string result = string.Empty;
            foreach (var card in list)
            {
                result += $"{card}, ";
            }
            return $"\nPlayer: {Id}\nCards ({result})";
        }
    }
}
