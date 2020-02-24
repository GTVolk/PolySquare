using System.Collections.Generic;

namespace DataTypes
{
    //ОБЬЯВЛЕНИЕ НОВЫХ ТИПОВ ДАННЫХ
    public class MyPoint : Ordered<MyPoint>
    {
        public double x, y, z;
        public MyPoint(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public MyPoint()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }
        public string ToString2D()
        {
            return "(" + x + ";" + y + ")";
        }
        public string ToString3D()
        {
            return "(" + x + ";" + y + ";" + z + ")";
        }
        public bool Equals(MyPoint p2)
        {
            return x == p2.x && y == p2.y;
        }

        public override bool Less(Ordered<MyPoint> o2)
        {
            MyPoint p2 = (MyPoint)o2;
            return x < p2.x || x == p2.x && y < p2.y;
        }

        // Twice the signed area of the triangle (p0, p1, p2)
        public static double Area2(MyPoint p0, MyPoint p1, MyPoint p2)
        {
            try
            {
                return p0.x * (p1.y - p2.y) + p1.x * (p2.y - p0.y) + p2.x * (p0.y - p1.y);
            }
            catch
            {
                return 0;
            }
        }
    }
    public struct Plane // Плоскость
    {
        public MyPoint p1, p2, p3;
    }
    public struct Polygon  // Многоугольник
    {
        public List<MyPoint> Poly;
        public MyPoint NormalVector;
    }
    public struct PlanePoints
    {
        public List<MyPoint> LastPts;
    }
    public abstract class Ordered<T>
    {
        public abstract bool Less(Ordered<T> that);
    }
}
