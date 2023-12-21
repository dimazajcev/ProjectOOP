using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP.Enums;

namespace ProjectOOP.Logic
{
    public class Deck
    {
        public List<Cards> deck = new List<Cards>();
        public Deck() 
        {
            Random random = new Random();
            Cards cards = new Cards();
            int count = 0;
            deck.Add((Cards)random.Next(6, 15));
            for (int i = 0; i < 35; i++) 
            {
                cards = (Cards)random.Next(6, 15);
                foreach (Cards card in deck)
                {
                    if (cards == card)
                        count++;
                }
                if (count > 4)
                {
                    do
                    {
                        cards = (Cards)random.Next(6, 15);
                        count = 0;
                        foreach (Cards card in deck)
                        {
                            if (cards == card)
                                count++;
                        }
                    } while (count > 4);
                }
                deck.Add(cards);
            }
        }

    }
}
