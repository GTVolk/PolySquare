using System;
using System.Collections.Generic;
using UserOperationsSet;
using DataTypes;

namespace Find3DPointsSetPolygonArea
{
    // КЛАСС ПРОГРАММЫ
    class Find3DPolygon
    {
        // ОСНОВНАЯ ПРОГРАММА
        public static bool CalculatePolySq(String[] ListPoints, ref double Square,ref List<MyPoint> pts)
        {
            bool Error = false;
            UserFunctions userFunctions = new UserFunctions();
            userFunctions.Input(ref Error,ListPoints);
            if (Error) return false;
            userFunctions.InitializePolygonFinding();
            userFunctions.Output(ref Square,ref pts);
            return true;
        }
    }
}
