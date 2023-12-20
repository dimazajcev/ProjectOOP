using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP.Enums;

namespace ProjectOOP.Interfaces
{
    public interface IPlayer
    {
        int Id { get; set; }
        int Count { get; set; }
        List<Cards> Cards { get; set; }
    }
}
