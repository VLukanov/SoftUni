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
}

namespace Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {

            var p1 = ReadPoint();
            var p2 = ReadPoint();
            Console.WriteLine("{0:f3}", CalcDestinace(p1, p2));
        }



        static Point ReadPoint()
        {
            var coord = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = new Point() { X = coord[0], Y = coord[1] };
            return p;
        }
        static double CalcDestinace(Point p1, Point p2)
        {
            var a = p1.X - p2.X;
            var b = p1.Y - p2.Y;
            var sum2 = a * a + b * b;
            var distance = Math.Sqrt(sum2);
            return distance;
        }

    }
}
