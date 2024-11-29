using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Field.Field
{
    public interface IFieldDisplayer
    {
        public static void ShowField(IPlayer player) { }
        public static void HideField() { }
    }
}
