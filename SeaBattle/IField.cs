using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    internal interface IField
    {
        public List<List<Cell>> GameField { get; set; }

    }
}
