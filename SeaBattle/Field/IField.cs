using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Field.Field
{
    internal interface IField
    {
        public static Dictionary<IPlayer, List<List<ICell>>> GameField { get; set; }
    }
}
