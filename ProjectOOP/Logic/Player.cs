using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP.Enums;
using ProjectOOP.Interfaces;

namespace ProjectOOP.Logic
{
    public delegate void PlayerCardCountChangedEventHandler(object sender, EventArgs e);
    public class Player: Characteristics, IString
    {
        private int count;
        public int Id { get; set; }
        public int Count 
        {
            get { return count; }
            set
            {
                if (value > 0 && value < 36)
                {
                    count = value;
                    OnPlayerCardCountChanged();
                }
            } 
        }
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
        public event PlayerCardCountChangedEventHandler PlayerCardCountChanged;
        protected virtual void OnPlayerCardCountChanged()
        {
            PlayerCardCountChanged?.Invoke(this, EventArgs.Empty);
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
