using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public interface ICell
    {
        public bool Fullness { get; set; }
        public void PlaceShipToCell();
        public void TakeShipFromCell();

    }
}
