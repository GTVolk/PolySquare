using System;
using DataTypes;
using CDLL;
using PolySortAlgoritms;

namespace ConvexHullAlgoritms
{
    class Convexhull
    {
        public static MyPoint[] convexhull(MyPoint[] pts)
        {
            // Отсортировать точки по увеличению (x, y)
            int N = pts.Length;
            Polysort.Quicksort<MyPoint>(pts);
            MyPoint left = pts[0], right = pts[N - 1];

            // Разделить на список нижних граней и верхних граней
            CDLL<MyPoint> lower = new CDLL<MyPoint>(left), upper = new CDLL<MyPoint>(left);
            for (int i = 0; i < N; i++)
            {
                double det = MyPoint.Area2(left, right, pts[i]);
                if (det > 0)
                    upper = upper.Append(new CDLL<MyPoint>(pts[i]));
                else if (det < 0)
                    lower = lower.Prepend(new CDLL<MyPoint>(pts[i]));
            }
            lower = lower.Prepend(new CDLL<MyPoint>(right));
            upper = upper.Append(new CDLL<MyPoint>(right)).Next;
            // Устранить точки не на многоуголнике
            eliminate(lower);
            eliminate(upper);

            // Устранить повторяющиеся точки
            try
            {
                if (lower.Prev.val.Equals(upper.val))
                    lower.Prev.Delete();
                if (upper.Prev.val.Equals(lower.val))
                    upper.Prev.Delete();
            }
            catch
            {
                // DO NOTHING!!! JUST SKIP ERROR
            }

            // Соединяем нижние и верхние грани
            MyPoint[] res = new MyPoint[lower.Size() + upper.Size()];
            lower.CopyInto(res, 0);
            upper.CopyInto(res, lower.Size());
            return res;
        }

        // Graham's scan
        private static void eliminate(CDLL<MyPoint> start)
        {
            CDLL<MyPoint> v = start, w = start.Prev;
            bool fwd = false;
            try
            {
                while (v.Next != start || !fwd)
                {
                    if (v.Next == w)
                        fwd = true;
                    if (MyPoint.Area2(v.val, v.Next.val, v.Next.Next.val) < 0) // правый поворот
                        v = v.Next;
                    else
                    {                                       // левый поворот или прямой проход
                        v.Next.Delete();
                        v = v.Prev;
                    }
                }
            }
            catch
            {
            }
        }

        // Установка центровой
        public static MyPoint centroid(MyPoint[] pts)
        {
            MyPoint p = new MyPoint();
            int N = pts.Length;
            double sumx = 0, sumy = 0;
            for (int i = 0; i < N; i++)
            {
                try
                {
                    p = pts[i];
                    sumx += p.x;
                    sumy += p.y;
                }
                catch
                {
                    return new MyPoint();
                }
            }
            return new MyPoint(sumx / N, sumy / N, 0);
        }

        // Площадь многоугольника (представлена массивом точек)
        public static double area(MyPoint[] pts)
        {
            int N = pts.Length;
            MyPoint centr = centroid(pts);
            double area2 = 0;
            for (int i = 0; i < N; i++)
                area2 += MyPoint.Area2(centr, pts[i], pts[(i + 1) % N]);
            return Math.Abs(area2 / 2);
        }
    }
}
