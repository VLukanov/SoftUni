using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopelNum = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)peopelNum / capacityElevator);
            Console.WriteLine(courses);
        }
    }
}
