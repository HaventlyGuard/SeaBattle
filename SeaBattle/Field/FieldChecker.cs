using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Field.Field
{
    
    public class FieldChecker : IFieldChecker
    {
        public bool CheckFieldForMiss(int x, int y)
        {
            // if (GameField[x,y].IsShipHere == false)
            // true
            throw new NotImplementedException();
        }

        public bool IsFieldFilledProperly(IShip ship)
        {
            ship.ShipHead.IsSamePoint(new Point());
            // if(ship.IsHorizontal == true)
            //      for (int i = ...; i < ... ; i++){
            // else
            //      for (int i = ...; i < ... ; i++){
            //          check
            // 

            //ЛИБО Спиралькой

            //while (l <= r && t <= b)
            //{
            //    for (int i = l; i <= r; ++i) D[ind++] = arr[t][i];
            //    ++t;
            //    for (int i = t; i <= b; ++i) D[ind++] = arr[i][r];
            //    --r;
            //    if (t <= b)
            //    {
            //        for (int i = r; i >= l; --i) D[ind++] = arr[b][i];
            //        --b;
            //    }
            //    if (l <= r)
            //    {
            //        for (int i = b; i >= t; --i) D[ind++] = arr[i][l];
            //        ++l;
            //    }
            //}

            //ЛИБО все клетки подряд

            //int height;
            //int width;
            //for (int i = 0; i < 1; i++)
            //{
            //    for (int j = 0; j < 1; j++) 
            //    {
            //        //условие на проверку корабля по координатам что типа Есть Х и У
            //        //и надо смотреть зависимость от того где голова корабля и сам размер коробля
            //    }
            //}
            return false;
        }

        //private bool CheckNeighborsCells(int x, int y, int delta1, int delta2)
        //{
        //    return false;
        //}
    }
}

//0 0 0 1 0 0 0
//0 1 0 1 0 1 0
//0 0 0 0 0 1 0 
//0 1 1 1 0 1 0 
//0 0 0 0 0 0 0 
//0 1 1 1 1 0 0 
//0 0 0 0 0 0 0

