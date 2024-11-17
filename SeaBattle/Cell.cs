using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Cell
    {
        public Ship? ship { get; set; }
        public bool Fullness { get; set; }
        public bool IsShipHere()
        {
            return false;
        }
    }
}
