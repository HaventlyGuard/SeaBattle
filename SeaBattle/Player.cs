using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    internal class Player : IPlayer
    {
        public int Id { get; set; }
        public IEnumerable<IShip> Ships { get ; set; }

        public IEnumerable<IEnumerable<ICell>> AttackOpponent(IEnumerable<IEnumerable<ICell>> field)
        {
            return field;
        }

        public IEnumerable<IEnumerable<ICell>> FillField(List<IEnumerable<ICell>> field)
        {
            return field;
        }
    }
}
