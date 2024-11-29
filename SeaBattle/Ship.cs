using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Ship : IShip
    {
        public int Size { get; set; }
        public bool IsHorizontal { get; set ; }
    }
}
