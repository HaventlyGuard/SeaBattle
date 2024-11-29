using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Player : IPlayer
    {
        public int Id { get; set; }
        public IEnumerable<IShip> Ships { get ; set; }

        public Player() : this(0) { }
        public Player(int Id)
        {
            this.Id = Id;
            Ships = GetShips();
        }
        public IEnumerable<IEnumerable<ICell>> AttackOpponent(IEnumerable<IEnumerable<ICell>> field)
        {
            return field;
        }

        public IEnumerable<IEnumerable<ICell>> FillField(List<IEnumerable<ICell>> field)
        {
            return field;
        }
        private IEnumerable<IShip> GetShips()
        {
            return new List<Ship>() {
                new Ship(1), new Ship(1), new Ship(1), new Ship(1),
                new Ship(2), new Ship(2), new Ship(2),
                new Ship(3), new Ship(3),
                new Ship(4),
            };
        }
    }
}
