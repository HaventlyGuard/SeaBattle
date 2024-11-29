﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Cell : ICell
    {
        public bool Fullness { get; set; }
        public bool IsShipHere()
        {
            return false;
        }
        public override string ToString()
        {
            return Fullness ? "O" : "X";
        }
    }
}
