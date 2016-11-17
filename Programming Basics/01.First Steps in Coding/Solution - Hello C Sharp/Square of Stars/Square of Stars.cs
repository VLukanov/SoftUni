using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            Console.WriteLine(new String('*',count));
            for (int i = 0; i < count-2; i++)
            {
                Console.WriteLine("*" + new String(' ',count-2) + "*");
            }
            Console.WriteLine(new String('*', count));
        }
    }
}
