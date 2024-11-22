using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Field.Field
{
    internal interface IFieldChecker : IField
    {
        public bool IsFieldFilledProperly(Ship ship);
        public bool CheckFieldForMiss(int x, int y);
    }
}
