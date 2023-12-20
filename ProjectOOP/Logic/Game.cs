using ProjectOOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.Logic
{
    public class Game: IPrintable
    {
        public int Id { get; set; }
        public int Count {  get; set; }
        public Game(int id, List<Player> players) 
        {
            throw new NotImplementedException();
        }
        public string PrintToDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
