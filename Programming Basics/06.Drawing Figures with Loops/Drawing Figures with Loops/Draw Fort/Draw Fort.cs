using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n <= 4)
            {
                Console.WriteLine("/" + new string('^', n / 2) + "\\"

                                  + "/" + new string('^', n / 2) + "\\");

                for (int i = 0; i < n - 2; i++)
                {
                    Console.WriteLine("|" + new string(' ', n * 2 - 2) + "|");
                }

                Console.WriteLine("\\" + new string('_', n / 2) + "/"

                                 + "\\" + new string('_', n / 2) + "/");

            }
            else
            {
                Console.WriteLine("/" + new string('^', n / 2) + "\\"
                                  + new string('_', n / 2)
                                  + "/" + new string('^', n / 2) + "\\");

                for (int i = 0; i < n - 3; i++)
                {
                    Console.WriteLine("|"+ new string(' ', n / 2 + 1)
                                      + new string(' ', n / 2)
                                      + new string(' ', n / 2 + 1) + "|");
                }

                Console.WriteLine("|" + new string (' ', n/2 + 1) 
                                      + new string('_', n / 2) 
                                      + new string(' ', n / 2 + 1)
                                      + "|");

                Console.WriteLine("\\" + new string('_', n / 2) + "/"
                                       + new string(' ', n / 2)
                                  + "\\" + new string('_', n / 2) + "/");

            
           } 
        }
    }
}
