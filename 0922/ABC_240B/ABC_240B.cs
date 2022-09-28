using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC240B
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.solve();
        }
        void solve()
        {
            var input = ReadInt();
            var N = input[0];
            var A = ReadInt();
            var set = A.Distinct();
            var set_count = set.Count();
            WriteInt(set_count);
        }
        List<int> ReadInt()
        {
            var check = new List<bool>();
            var input = Console.ReadLine().Split(' ').Select(x => {
                var temp = 0;
                check.Add(int.TryParse(x, out temp));
                return temp;
            }).ToList();
            if (check.Any(x => x == false)) return null;
            return input;
        }
        void WriteInt(int output)
        {
            Console.WriteLine(output);
        }
    }
}