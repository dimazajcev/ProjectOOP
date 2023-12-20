using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP.Enums;
using ProjectOOP.Interfaces;

namespace ProjectOOP.Logic
{
    public class Player: IPlayer
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public List<Cards> Cards { get; set; }
        public Player(int id, int cards) 
        {
            throw new NotImplementedException();
        }
    }
}
