using System;
using System.Collections.Generic;
using DataTypes;

namespace PointFunctions
{
    public class PointOperations // Операции над точками
    {
        public void ConvertPlaneToPointArray(Plane pl, List<MyPoint> pts)
        {
            pts[0] = pl.p1;
            pts[1] = pl.p2;
            pts[2] = pl.p3;
        }
        public Plane ConvertToPlane(List<MyPoint> pts)
        {
            Plane pl;
            pl.p1 = pts[0];
            pl.p2 = pts[1];
            pl.p3 = pts[2];
            return pl;
        }
        public double[] PointFromStrToArr(string s)
        {
            double[] a = new double[3];
            int IndS = 0, IndE = 0, i = 0;
            String t = "";
            IndS = s.IndexOf(" X = ") + 5;
            IndE = s.IndexOf(" Y = ") - 1;
            for (i = IndS; i < IndE; i++)
                t = t + s[i];
            a[0] = double.Parse(t);
            t = "";
            IndS = s.IndexOf(" Y = ") + 5;
            IndE = s.IndexOf(" Z = ") - 1;
            for (i = IndS; i < IndE; i++)
                t = t + s[i];
            a[1] = double.Parse(t);
            t = "";
            IndS = s.IndexOf(" Z = ") + 5;
            IndE = s.Length;
            for (i = IndS; i < IndE; i++)
                t = t + s[i];
            a[2] = double.Parse(t);
            return a;
        }
        public void InputPoints(byte numb, String[] ListPoints,List<MyPoint> pts, ref bool Error)
        {
            for (int i = 0; i < ListPoints.Length; i++)
            {
                Console.WriteLine("Введите координаты (x,y,z) " + (i + 1) + " точки:");
                MyPoint TMP = new MyPoint();
                double[] ar = new double[3];
                try
                {
                    ar = PointFromStrToArr(ListPoints[i]);
                    TMP.x = ar[0];
                    TMP.y = ar[1];
                    TMP.z = ar[2];
                }
                catch
                {
                    Error = true;
                    return;
                }
                pts.Add(TMP);
            }
        }
    }
}
