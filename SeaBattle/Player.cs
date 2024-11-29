using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    internal class Player : IPlayer
    {
        int IPlayer.Id { get; set; }
        IEnumerable<Ship> IPlayer.Ships { get; set; }

        public IEnumerable<IEnumerable<Cell>> FillField(IEnumerable<IEnumerable<Cell>> field)
        {
            return field;
        }

        public IEnumerable<IEnumerable<Cell>> AttackOpponent(IEnumerable<IEnumerable<Cell>> field)
        {
            return field;
        }
    }
}
