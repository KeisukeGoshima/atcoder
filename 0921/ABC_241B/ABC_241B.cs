using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC241B
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
            if (input == null) return ;
            var N = input[0];
            var M = input[1];
            var A = ReadInt();
            if (A == null) return ;
            var B = ReadInt();
            if (B == null) return ;
            var result = Enumerable.Range(0, M).Select(x => A.Count(y => y == B[x]) >= B.Count(z => z == B[x])).ToList();
            if (result.Any(x => x == false)) Console.WriteLine("No");
            else Console.WriteLine("Yes");
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