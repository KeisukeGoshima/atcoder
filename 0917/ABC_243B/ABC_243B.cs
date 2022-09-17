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
            var solve1 = Enumerable.Range(0, N).Where(x => A[x] == B[x]).Count();
            var solve2 = Enumerable.Range(0, N).Where(x => A.Any(y => y == B[x])).Count();
            WriteInt(solve1);
            WriteInt(solve2 - solve1);
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