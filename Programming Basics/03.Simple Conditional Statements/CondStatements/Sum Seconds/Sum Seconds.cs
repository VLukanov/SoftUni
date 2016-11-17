using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            var seconds = num1 + num2 + num3;            
            var totalMinutes = seconds / 60 ;
            seconds = seconds % 60;

            if (seconds < 10)
            {
                Console.WriteLine(totalMinutes + ":" + "0" + seconds);
            }
            else
                Console.WriteLine(totalMinutes + ":" + seconds);
        }
    }
}
