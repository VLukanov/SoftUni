using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();


            if (name == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", a * a);

            }
            else if (name == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F3}", a * b);
            }
            else if (name == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", Math.PI * r * r);
            }
            else if (name == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", (a * h) / 2);
            }
        }
    }
}
