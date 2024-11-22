﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    internal class Player : IPlayer
    {
        int IPlayer.Id { get; set; }
        List<Ship> IPlayer.Ships { get; set; }

        public List<List<Cell>> FillField(List<List<Cell>> field) 
        {
            return field;
        }
        public List<List<Cell>> AttackOpponent(List<List<Cell>> field)
        {
            return field;
        }
    }
}
