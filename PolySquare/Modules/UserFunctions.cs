using System;
using System.Collections.Generic;
using DataTypes;
using UserGlobalsSet;

namespace UserOperationsSet
{
    public class UserFunctions
    {
        // ИНИЦИАЛИЗАЦИЯ ГЛОБАЛЬНЫХ ПЕРЕМЕННЫХ И МЕТОДОВ
        public UserGlobals BD;

        public UserFunctions()
        {
            BD = new UserGlobals();
        }

        // МЕТОДЫ ДЛЯ РЕШЕНИЯ ЗАДАЧИ
        public void BruteMod(int i)
        {
            for (int x = 0; x < BD.Points; ++x)
            {
                if (!BD.TPM.Contains(BD.PM[x]))
                {

                    BD.TPM[i] = BD.PM[x];
                    if (i < 2)
                        BruteMod(i + 1);
                    else
                    {
                        int TempNumber = BD.LastIndex;
                        if (!BD.PMContainsPoint(BD.TPM,BD.PM,BD.LastPoints, ref TempNumber))
                        {
                            BD.PPM.Add(BD.ConvertToPlane(BD.TPM));
                            BD.LastIndex = TempNumber;
                        }
                    }
                }
            }
        }

        public void CopyMaxPolyAttributes(MyPoint[] Polyin,double Square)
        {
            BD.MaxPolySquare = Square;
            BD.MaxPolyPointsArray.Clear();
            BD.MaxPolyPointsArray.AddRange(Polyin);
        }
        public void InitializePolygonFinding()
        {
            MyPoint ZP = new MyPoint();
            BD.TPM.Add(ZP);
            BD.TPM.Add(ZP);
            BD.TPM.Add(ZP);
            BruteMod(0);
            BD.LastIndex = 0;
            foreach (PlanePoints x in BD.LastPoints)
                x.LastPts.Clear();
            BD.LastPoints.Clear();
            FindMaxPolygonSquare(BD.PPM, BD.PPM.Count);
        }
        public double FindMaxPolygonSquare(List<Plane> lpl, int cnt)
        {
            double temp, f = 0;
            bool first = true;
            MyPoint[] TempPoly = new MyPoint[BD.Points];
            for (int i = 0; i < cnt; i++)
            {
                BD.ConvertPlaneToPointArray(lpl[i], BD.TPM);
                BD.FindPlanePoints(BD.TPM, BD.PM, BD.PolygonArray, BD.Points);
                BD.GeneratePolygon(BD.PolygonArray[i], ref TempPoly, BD.Points);
                temp = BD.PolygonSquare(TempPoly);
                if (first || f < temp)
                {
                    first = false;
                    f = temp;
                    CopyMaxPolyAttributes(TempPoly,temp);
                }
            }
            return f;
        }
        public void Input(ref bool Error,String[] ListPoints)
        {
            BD.Points = (byte)ListPoints.Length;
            BD.InputPoints(BD.Points, ListPoints, BD.PM, ref Error);
            if (Error) return;

        }
        public void Output(ref double Square,ref List<MyPoint> Pts)
        {
            Square = BD.MaxPolySquare;
            Pts = BD.MaxPolyPointsArray;
            BD.PolygonArray.Clear();
            BD.PPM.Clear();
            BD.TPM.Clear();
            BD.PM.Clear();
        }
    }
}
