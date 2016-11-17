using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var currency0 = Console.ReadLine();
            var currency1 = Console.ReadLine();

            if (currency0 == "USD")
            {
                if (currency1 == "BGN")
                {
                    Console.WriteLine(Math.Round(num* 1.79549, 2));
                }
                else if (currency1 == "EUR")
                {
                    Console.WriteLine(Math.Round((num * 1.79549)/1.95583, 2));
                }
                else if (currency1 == "GBP")
                {
                    Console.WriteLine(Math.Round((num * 1.79549) / 2.53405, 2));
                }
            }
            if (currency0 == "EUR")
            {
                if (currency1 == "BGN")
                {
                    Console.WriteLine(Math.Round(num * 1.95583, 2));
                }
                else if (currency1 == "USD")
                {
                    Console.WriteLine(Math.Round((num * 1.95583) / 1.79549, 2));
                }
                else if (currency1 == "GBP")
                {
                    Console.WriteLine(Math.Round((num * 1.95583) / 2.53405, 2));
                }
            }
            if (currency0 == "GBP")
            {
                if (currency1 == "BGN")
                {
                    Console.WriteLine(Math.Round(num * 2.53405, 2));
                }
                else if (currency1 == "EUR")
                {
                    Console.WriteLine(Math.Round((num * 2.53405) / 1.95583, 2));
                }
                else if (currency1 == "USD")
                {
                    Console.WriteLine(Math.Round((num * 2.53405) / 1.79549, 2));
                }
            }
            if (currency0 == "BGN")
            {
                if (currency1 == "GBP")
                {
                    Console.WriteLine(Math.Round(num / 2.53405, 2));
                }
                else if (currency1 == "EUR")
                {
                    Console.WriteLine(Math.Round(num / 1.95583, 2));
                }
                else if (currency1 == "USD")
                {
                    Console.WriteLine(Math.Round(num / 1.79549, 2));
                }
            }
        }
    }
}
