using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var counts = new SortedDictionary<double, int>(); // new int[1000]

            //foreach (var num in input)
            //{
            //    counts[num]++;
            //}
            //for (int i = 0; i < counts.Length; i++)
            //{
            //    if (counts[i] > 0)
            //    {
            //        Console.WriteLine("{0} -> {1}", i, counts[i]);
            //    }

            foreach (var num in input)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            foreach (var n in counts.Keys)
            {
                if (counts[n] > 0)
                {
                    Console.WriteLine("{0} -> {1}", n, counts[n]);
                }
            }

            }
        }
    }

