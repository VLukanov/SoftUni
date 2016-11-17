using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inches = double.Parse(Console.ReadLine());
            var cent = inches * 2.54;
            Console.WriteLine("Inches = {0}", inches);
            Console.WriteLine("Centimeters = {0}", cent);
        }
    }
}
