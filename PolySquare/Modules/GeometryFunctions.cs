using System;
using System.Collections.Generic;
using DataTypes;
using System.Windows.Forms;

// ОБЬЯВЛЕНИЕ ГЕОМЕТРИЧЕСКИХ МЕТОДОВ
namespace GeometryOperations
{
    public class GeometryFunctions
    {
        public const double eps = 0.01;
        public static void CopyCoordSystemToPlane(Polygon polyin, Polygon polyout)
        {
            MyPoint p = new MyPoint();
            MyPoint Raz = new MyPoint();
            Raz = polyin.Poly[0];
            for (int i = 0; i < polyin.Poly.Count; i++)
            {
                p = polyin.Poly[i];
                MyPoint r = new MyPoint();
                r.x = p.x - Raz.x;
                r.y = p.y - Raz.y;
                r.z = p.z - Raz.z;
                polyout.Poly.Add(r);
            }
            polyout.NormalVector = polyin.NormalVector;
        }
        public static void MultiplyMatrix(double[,] a, double[,] b, int n1, int m1, int n2, int m2, double[,] c)
        {
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < m2; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < m1; k++)
                        c[i, j] += a[i, k] * b[k, j];
                }
        }
        public static MyPoint findEdgePointZ(List<MyPoint> pts)
        {
            MyPoint tp = new MyPoint();
            for (int i = 0; i < pts.Count; i++)
                if ((Math.Abs(pts[i].x) > Math.Abs(tp.x)) || (Math.Abs(pts[i].z) > Math.Abs(tp.z)) && (Math.Abs(Math.Abs(tp.x) - Math.Abs(tp.z))<Math.Abs(Math.Abs(pts[i].x) - Math.Abs(pts[i].z))))
                    tp = pts[i];
            return tp;
        }
        public static MyPoint findEdgePointX(List<MyPoint> pts)
        {
            MyPoint tp = new MyPoint();
            for (int i = 0; i < pts.Count; i++)
                if (Math.Abs(pts[i].x) > Math.Abs(tp.x))
                    tp = pts[i];
            return tp;
        }

        public static double getAngleX(MyPoint p)
        {
            if ((p.x == 0 && p.z == 0)) return 0;
            if (p.z < 0)
            {
                MyPoint pr = new MyPoint(1, 0, 0);
                return -Math.Acos((pr.x * p.x + pr.y * 0 + pr.z * p.z) / (Math.Sqrt(p.x * p.x + 0 * 0 + p.z * p.z) * Math.Sqrt(pr.x * pr.x + pr.y * pr.y + pr.z * pr.z)));
            }
            else
            {
                MyPoint pr = new MyPoint(-1, 0, 0);
                return -Math.Acos((pr.x * p.x + pr.y * 0 + pr.z * p.z) / (Math.Sqrt(p.x * p.x + 0 * 0 + p.z * p.z) * Math.Sqrt(pr.x * pr.x + pr.y * pr.y + pr.z * pr.z)));
            }
        }
        public static double getAngleY(MyPoint p)
        {
            if ((p.y == 0 && p.z == 0)||(p.z == 0)) return 0;
            if (p.z < 0)
            {
                MyPoint pr = new MyPoint(0, 1, 0);
                return Math.Acos((pr.x * 0 + pr.y * p.y + pr.z * p.z) / (Math.Sqrt(0 * 0 + p.y * p.y + p.z * p.z) * Math.Sqrt(pr.x * pr.x + pr.y * pr.y + pr.z * pr.z)));
            }
            else
            {
                MyPoint pr = new MyPoint(0, -1, 0);
                return Math.Acos((pr.x * 0 + pr.y * p.y + pr.z * p.z) / (Math.Sqrt(0 * 0 + p.y * p.y + p.z * p.z) * Math.Sqrt(pr.x * pr.x + pr.y * pr.y + pr.z * pr.z)));
            }
        }
        public static double getAngleZ(MyPoint p)
        {
            if ((p.x == 0 && p.y == 0)) return 0;
            if (p.x < 0)
            {
                int multiplayer = 1;
                if (p.y < 0) multiplayer = -1;
                MyPoint pr = new MyPoint(-1, 0, 0);
                return multiplayer*Math.Acos((pr.x * p.x + pr.y * p.y + pr.z * 0) / (Math.Sqrt(p.x * p.x + p.y * p.y + 0 * 0) * Math.Sqrt(pr.x * pr.x + pr.y * pr.y + pr.z * pr.z)));
            }
            else
            {
                int multiplayer = -1;
                if (p.y < 0) multiplayer = 1;
                MyPoint pr = new MyPoint(1, 0, 0);
                return multiplayer*Math.Acos((pr.x * p.x + pr.y * p.y + pr.z * 0) / (Math.Sqrt(p.x * p.x + p.y * p.y + 0 * 0) * Math.Sqrt(pr.x * pr.x + pr.y * pr.y + pr.z * pr.z)));
            }
        }
        public static void RotatePlaneCoordSystem(Polygon polyin, Polygon polyout)
        {
            MyPoint p = new MyPoint();
            p = findEdgePointZ(polyin.Poly);
            double angleP = getAngleX(p);
            List<MyPoint> TempPoints = new List<MyPoint>();
            double[,] r1 = new double[3, 3];
            double[,] r2 = new double[3, 1];
            double[,] r3 = new double[3, 1];
            for (int i = 0; i < polyin.Poly.Count; i++)
            {
                MyPoint rt = new MyPoint();
                p = polyin.Poly[i];
                InitializeRotateMatrixY(r1, angleP);
                InitializePointMatrix(p, r2);
                MultiplyMatrix(r1, r2, 3, 3, 3, 1, r3);
                rt.x = r3[0, 0];
                rt.y = r3[1, 0];
                rt.z = r3[2, 0];
                TempPoints.Add(rt);
            }
            p = findEdgePointX(TempPoints);
            angleP = getAngleZ(p);
            for (int i = 0; i < polyin.Poly.Count; i++)
            {
                MyPoint rt = new MyPoint();
                p = TempPoints[i];
                InitializeRotateMatrixZ(r1, angleP);
                InitializePointMatrix(p, r2);
                MultiplyMatrix(r1, r2, 3, 3, 3, 1, r3);
                rt.x = r3[0, 0];
                rt.y = r3[1, 0];
                rt.z = r3[2, 0];
                double angleS = getAngleY(rt);
                InitializeRotateMatrixX(r1, angleS);
                InitializePointMatrix(rt, r2);
                MultiplyMatrix(r1, r2, 3, 3, 3, 1, r3);
                rt.x = r3[0, 0];
                if (Double.IsNaN(rt.x)) rt.y = 0;
                rt.y = r3[1, 0];
                if (Double.IsNaN(rt.y)) rt.y = 0;
                rt.z = r3[2, 0];
                if (Double.IsNaN(rt.z)) rt.y = 0;
                polyout.Poly.Add(rt);
            }
        }
        public static void InitializePointMatrix(MyPoint p, double[,] r2)
        {
            r2[0, 0] = p.x;
            r2[1, 0] = p.y;
            r2[2, 0] = p.z;
        }
        public static void InitializeRotateMatrixX(double[,] r1, double angle)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    r1[i, j] = 0;
            r1[0, 0] = 1;
            r1[1, 1] = Math.Cos(angle);
            r1[1, 2] = -Math.Sin(angle);
            r1[2, 1] = Math.Sin(angle);
            r1[2, 2] = Math.Cos(angle);
        }
        public static void InitializeRotateMatrixY(double[,] r1, double angle)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    r1[i, j] = 0;
            r1[0, 0] = Math.Cos(angle);
            r1[0, 2] = Math.Sin(angle);
            r1[1, 1] = 1;
            r1[2, 0] = -Math.Sin(angle);
            r1[2, 2] = Math.Cos(angle);
        }
        public static void InitializeRotateMatrixZ(double[,] r1, double angle)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    r1[i, j] = 0;
            r1[0, 0] = Math.Cos(angle);
            r1[0, 1] = -Math.Sin(angle);
            r1[1, 0] = Math.Sin(angle);
            r1[1, 1] = Math.Cos(angle);
            r1[2, 2] = 1;
        }
    }
}
