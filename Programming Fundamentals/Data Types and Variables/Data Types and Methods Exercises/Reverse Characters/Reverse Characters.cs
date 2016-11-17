using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            string rev = a + b + c;
            char[] newWord = rev.ToCharArray();
            Array.Reverse(newWord);
            string outPut = new string(newWord);

            Console.WriteLine(outPut);
        }
    }
}
