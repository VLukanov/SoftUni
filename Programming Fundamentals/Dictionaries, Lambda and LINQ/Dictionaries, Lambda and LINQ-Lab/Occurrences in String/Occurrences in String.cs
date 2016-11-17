using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occurrences_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var w = Console.ReadLine();
            var start = 0;
            var count = 0;

            while (true)
            {
                var position = text.IndexOf(w, start, StringComparison.InvariantCultureIgnoreCase);
                if (position == -1)
                {
                    break;
                }
                else
                {
                    count++;
                    start = position + 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
