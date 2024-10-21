using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Ship
    {
        private int Size { get;}
        private int X { get; }
        private int Y { get; }
        private bool IsHorizontal { get; set; }

        public Ship(int size, int x, int y, bool isHorizontal)
        {
            Size = size;
            X = x;
            Y = y;
            IsHorizontal = isHorizontal;
        }


        public void ChangeDirection()
        {
            if (IsHorizontal) {
                IsHorizontal = false; 
            }
            else IsHorizontal = true;
        }
        public void DestroyShip()
        {
            Console.WriteLine($"Корабль размером {Size} был уничтожен");
        }
    }
}
