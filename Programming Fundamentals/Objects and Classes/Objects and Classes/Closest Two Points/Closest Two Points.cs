using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    public string Name { get; set; }
    public double X { get; set; }
    public double Y { get; set; }

    public override string ToString()
    {
        return string.Format("{0} ({1}, {2})");
    }
    public static Point ReadPoint()
    {
        var coord = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var p = new Point() { X = coord[0], Y = coord[1] };
        return p;
    }
    public static double CalcDestinace(Point p1, Point p2)
    {
        var a = p1.X - p2.X;
        var b = p1.Y - p2.Y;
        var sum2 = a * a + b * b;
        var distance = Math.Sqrt(sum2);
        return distance;
    }

}

namespace Closest_Two_Points
{
    class Program
    {
         public static void Main(string[] args)
        {

            var points = ReadArrayOfPoints();
            var nearestPoints = FindNearestPoints(points);
            Console.WriteLine(Point.CalcDestinace(nearestPoints[1], nearestPoints[2]));
            Console.WriteLine(nearestPoints[0]);
            Console.WriteLine(nearestPoints[1]);
        }

        public static Point[] FindNearestPoints(Point[] points)
        {
            var minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    var distance = Point.CalcDestinace(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] {
          points[p1], points[p2] };
                    }
                }
            return closestTwoPoints;

        }

        public static Point[] ReadArrayOfPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];
            for (int i = 0; i < n-1; i++)
            {
                points[i] = Point.ReadPoint();
            }
            return points;
        }
    }
}
