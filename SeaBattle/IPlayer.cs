using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    internal interface IPlayer
    {
        public int Id { get; set; }
        public List<Ship> Ships { get; set; }
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
