using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var separatores = new char[] { ',', ';', ':', '.', '!', ' ', '(', ')', '"', '\'', '/', '\\', '[', ']'  };            

            var words = Console.ReadLine().Split(separatores,StringSplitOptions.RemoveEmptyEntries).ToList();
            
            List<string> lower = new List<string>();
            List<string> mixd = new List<string>();
            List<string> upper = new List<string>();

            foreach (var w in words)
            {
                var type = GetWordType(w);
                if (type == WordType.Uppercase)
                {
                    upper.Add(w);
                }
                else if (type == WordType.Lowercase)
                {
                    lower.Add(w);
                }
                else
                {
                    mixd.Add(w);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lower)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixd)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upper)}");
        }

        enum WordType {Uppercase, Mixedcase, Lowercase};

        static WordType GetWordType(string word)
        {
            var lowerLetters = 0;
            var upperLetters = 0;
            foreach (var l in word)
            {
                if (char.IsUpper(l))
                {
                    upperLetters++;
                }
                else if (char.IsLower(l))
                {
                    lowerLetters++;
                }
            }
            if (upperLetters == word.Length)
            {
                return WordType.Uppercase;
            }
            else if (lowerLetters == word.Length)
            {
                return WordType.Lowercase;
            }
            else
            {
                return WordType.Mixedcase;
            }
        }
    }
}
