using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP.Logic
{
    public class Info
    {
        public int Result {  get; set; }
        public Info(List<Player> players)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{Result}";
        }
    }
}
