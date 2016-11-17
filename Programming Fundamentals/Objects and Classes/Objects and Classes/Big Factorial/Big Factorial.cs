using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            BigInteger facturial = 1;
            for (int i = 1; i <= num; i++)
            {
                facturial *= i;
            }
            Console.WriteLine(facturial);
        }
    }
}
