using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population_Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            var townsByCountry =new SortedDictionary<string, HashSet<string>>();


            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd == "stop")
                {
                    break;
                }
                var cmdTokens = cmd.Split('\\');
                //var countryName = cmdTokens[0];
                var country = RemovebadChars(cmdTokens[0]);
                var town = RemovebadChars(cmdTokens[1]);
                if (char.IsUpper(country[0]))
                {
                    var old = country;
                    country = town;
                    town = old;
                }
                //to do
            }
        }

        static string RemovebadChars(string str)
        {
            var validCharsOnly = cmdTokens[0].Split("@#$&0123456789".ToArray());
            var combine = string.Join(" ", validCharsOnly);
            return combine;
        }
    }
}
