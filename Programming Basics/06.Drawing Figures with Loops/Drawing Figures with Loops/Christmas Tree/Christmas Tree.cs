using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
           // Console.Write(new string (' ',n+1) + "|");

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write(new string('*', i));

                Console.Write(" | ");

                Console.Write(new string('*', i));

                Console.WriteLine();
            }            
        }
    }
}
