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
        public IEnumerable<Ship> Ships { get; set; }
        public IEnumerable<IEnumerable<Cell>> FillField(IEnumerable<IEnumerable<Cell>> field);
        public IEnumerable<IEnumerable<Cell>> AttackOpponent(IEnumerable<IEnumerable<Cell>> field);
    }
}
