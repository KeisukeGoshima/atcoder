using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC_243B
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
            var A = ReadInt();
            if (A == null) return ;
            var B = ReadInt();
            if (B == null) return ;
            var perfectMatch = Enumerable.Range(0, N).Where(x => A[x] == B[x]).Count();
            var partialMatch = Enumerable.Range(0, N).Where(x => A.Any(y => y == B[x])).Count();
            WriteInt(perfectMatch);
            WriteInt(perfectMatch - partialMatch);
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
        void WriteInt(int solve)
        {
            Console.WriteLine(solve);
        }
    }
}