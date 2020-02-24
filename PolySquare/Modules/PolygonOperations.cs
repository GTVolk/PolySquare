using System.Collections.Generic;
using DataTypes;
using PointFunctions;
using ConvexHullAlgoritms;
using GeometryOperations;

namespace PolygonFunctions
{
    public class PolygonOperations : PointOperations // Операции над многоугольниками
    {
        public void InsertArrayInPolygon(List<MyPoint> pts, Polygon polyout)
        {
            for (int i = 0; i < pts.Count; i++)
            {
                if (!(polyout.Poly.Contains(pts[i])))
                    polyout.Poly.Add(pts[i]);
            }
        }
        public void CalculatePolyConvexEdge(Polygon polyin, ref MyPoint[] ptsout)
        {
            int N = polyin.Poly.Count;
            MyPoint[] pts = polyin.Poly.ToArray();
            MyPoint[] chpts = Convexhull.convexhull(pts);
            ptsout = chpts;
        }

        public double PolygonSquare(MyPoint[] pts) // Площадь многоугольника
        {
            double s = 0;
            s = Convexhull.area(pts);
            return s;
        }
        public void GeneratePolygon(Polygon polyin, ref MyPoint[] pts, byte numb)// Построение многоугольника
        {
            Polygon t1, t2;
            MyPoint[] t3 = new MyPoint[numb];
            t1.Poly = new List<MyPoint>();
            t1.NormalVector = new MyPoint();
            t2.Poly = new List<MyPoint>();
            t2.NormalVector = new MyPoint();
            GeometryFunctions.CopyCoordSystemToPlane(polyin, t1);
            GeometryFunctions.RotatePlaneCoordSystem(t1, t2);
            CalculatePolyConvexEdge(t2, ref t3);
            pts = t3;
        }
        public bool PMContainsPoint(List<MyPoint> tpts, List<MyPoint> pts, List<PlanePoints> outpts, ref int LastInd)
        {
            for (int i = 0; i < outpts.Count; i++)
                if (outpts[i].LastPts.Contains(tpts[0]) && outpts[i].LastPts.Contains(tpts[1]) && outpts[i].LastPts.Contains(tpts[2])) return true;
            double A = 0, B = 0, C = 0, D = 0;
            ++LastInd;
            int h = LastInd;
            PlanePoints a;
            a.LastPts = new List<MyPoint>();
            outpts.Add(a);
            PlanePoints ot = outpts[h-1];
            ot.LastPts.AddRange(tpts);
            GetPointsInPlane(tpts, pts, ot.LastPts, ref A, ref B, ref C, ref D);
            return false;
        }
        public void GetPointsInPlane(List<MyPoint> tpts, List<MyPoint> pts, List<MyPoint> outpts,ref double A,ref double B,ref double C,ref double D)
        {
            double PlaneCoef = 0;
            A = tpts[0].y * (tpts[1].z - tpts[2].z) + tpts[1].y * (tpts[2].z - tpts[0].z) + tpts[2].y * (tpts[0].z - tpts[1].z);
            B = tpts[0].z * (tpts[1].x - tpts[2].x) + tpts[1].z * (tpts[2].x - tpts[0].x) + tpts[2].z * (tpts[0].x - tpts[1].x);
            C = tpts[0].x * (tpts[1].y - tpts[2].y) + tpts[1].x * (tpts[2].y - tpts[0].y) + tpts[2].x * (tpts[0].y - tpts[1].y);
            D = tpts[0].x * (tpts[1].y * tpts[2].z - tpts[2].y * tpts[1].z) + tpts[1].x * (tpts[2].y * tpts[0].z - tpts[0].y * tpts[2].z) + tpts[2].x * (tpts[0].y * tpts[1].z - tpts[1].y * tpts[0].z);
            D = -D;
            foreach (MyPoint x in pts)
                if (!tpts.Contains(x))
                {
                    PlaneCoef = ((A * (x.x)) + (B * (x.y)) + (C * (x.z)) + D);
                    if (PlaneCoef == 0)
                    {
                        outpts.Add(x);
                    }
                }
        }

        public void FindPlanePoints(List<MyPoint> tpts, List<MyPoint> pts, List<Polygon> lpolyout, byte numb) // Нахождение точек принадлежащих плоскости
        {
            double A = 0, B = 0, C = 0, D = 0;
            Polygon PL;
            PL.Poly = new List<MyPoint>();
            PL.NormalVector = new MyPoint();
            InsertArrayInPolygon(tpts, PL);
            GetPointsInPlane(tpts,pts,PL.Poly,ref A,ref B,ref C,ref D);
            PL.NormalVector = new MyPoint(A, B, C);
            lpolyout.Add(PL);
        }
    }
}
