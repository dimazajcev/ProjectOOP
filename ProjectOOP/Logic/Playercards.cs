using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP.Enums;

namespace ProjectOOP.Logic
{
    public class Playercards
    {
        public List<Cards> Cardsplayer = new List<Cards>();
        public int Count { get; set; }
        public Playercards(int count, List<Cards> deck) 
        {
            if (count > 0 && count < 36)
                Count = count;
            if (deck.Count > 0 && deck.Count <= 36)
                for (int i = 0; i < count; i++)
                    Cardsplayer.Add(CountCards(deck));
        }
        public Cards CountCards(List<Cards> deck)
        {
            Cards card = deck[deck.Count - 1];
            deck.RemoveAt(deck.Count - 1);
            return card;
        }
    }
}
