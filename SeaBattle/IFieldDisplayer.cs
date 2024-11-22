using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    internal interface IFieldDisplayer : IField
    {
        public void ShowField(int index);
        public void HideField();
    }
}
