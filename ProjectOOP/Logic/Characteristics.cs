using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP.Enums;

namespace ProjectOOP.Logic
{
    public abstract class Characteristics
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public List<Cards> list { get; set; }
    }
}
