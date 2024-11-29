using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }


        public bool IsSamePoint(Point other)
        {
            return other.X == X && other.Y == Y;
        }
    }
}
