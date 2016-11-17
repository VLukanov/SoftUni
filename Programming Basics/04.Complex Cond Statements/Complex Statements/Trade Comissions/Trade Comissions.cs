using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var sell = double.Parse(Console.ReadLine());
            var commision = 1.0;
            var tradeCommision = sell * commision;

            if (sell >= 0 && sell <= 500)
            {
                if (town == "Sofia")
                {
                    commision = 0.05;
                }
                else if (town == "Varna")
                {
                    commision = 0.045;
                }
                else if (town == "Plovdiv")
                {
                    commision = 0.055;
                }
                Console.WriteLine("{0:f2}", tradeCommision * commision);
            }
           
            if (sell > 500 && sell <= 1000)
            {
                if (town == "Sofia")
                {
                    commision = 0.07;
                }
                else if (town == "Varna")
                {
                    commision = 0.075;
                }
                else if (town == "Plovdiv")
                {
                    commision = 0.080;
                }
                Console.WriteLine("{0:f2}", tradeCommision * commision);
            }
            
            if (sell > 1000 && sell <= 10000)
            {
                if (town == "Sofia")
                {
                    commision = 0.08;
                }
                else if (town == "Varna")
                {
                    commision = 0.1;
                }
                else if (town == "Plovdiv")
                {
                    commision = 0.12;
                }
                Console.WriteLine("{0:f2}", tradeCommision * commision);
            }
           
            if (sell > 10000)
            {
                if (town == "Sofia")
                {
                    commision = 0.12;
                }
                else if (town == "Varna")
                {
                    commision = 0.13;
                }
                else if (town == "Plovdiv")
                {
                    commision = 0.145;
                }
                Console.WriteLine("{0:f2}", tradeCommision * commision);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
