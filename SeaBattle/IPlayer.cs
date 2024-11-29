using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public interface IPlayer
    {
        public int Id { get; set; }
        public IEnumerable<IShip> Ships { get; set; }
        public IEnumerable<IEnumerable<ICell>> FillField(IEnumerable<IEnumerable<ICell>> field);
        public IEnumerable<IEnumerable<ICell>> AttackOpponent(IEnumerable<IEnumerable<ICell>> field);
    }
}
