using System.Collections.Generic;
using DataTypes;
using PolygonFunctions;

namespace UserGlobalsSet
{
    // ПОЛЬЗОВАТЕЛЬСКИЕ ГЛОБАЛЬНЫЕ ПЕРЕМЕННЫЕ
    public class UserGlobals : PolygonOperations
    {
        public byte Points { get; set; }
        public int LastIndex { get; set; }
        public double MaxPolySquare { get; set; }
        public List<MyPoint> MaxPolyPointsArray { get; set; }
        public List<Polygon> PolygonArray { get; set; }
        public List<MyPoint> PM { get; set; }
        public List<MyPoint> TPM { get; set; }
        public List<Plane> PPM { get; set; }
        public List<PlanePoints> LastPoints { get; set; }
        public UserGlobals()
        {
            Points = 0;
            LastIndex = 0;
            MaxPolySquare = 0;
            MaxPolyPointsArray = new List<MyPoint>();
            PolygonArray = new List<Polygon>();
            PM = new List<MyPoint>();
            TPM = new List<MyPoint>();
            PPM = new List<Plane>();
            LastPoints = new List<PlanePoints>();
        }
    }
}
