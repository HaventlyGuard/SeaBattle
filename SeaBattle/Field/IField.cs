﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Field.Field
{
    internal interface IField
    {
        public static Dictionary<int, List<List<Cell>>> GameField { get; set; }
    }
}