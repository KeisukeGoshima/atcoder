using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC268_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var input = program.Read();
            if (input == null) return;
            var N = input[0];
            var p = program.Read();
            if (p == null) return;
            var result = Enumerable.Range(0, N).Select(x => {
                var temp = p[x] - x;
                if (temp < 0) return temp + N;
                return temp;
                }).ToList();
            var solve = Enumerable.Repeat(0, N).ToList();
            result.ForEach(x => {
                if (x == 0)
                {
                    solve[N-1]++;
                    solve[x+1]++;
                }
                else if (x == N - 1)
                {
                    solve[0]++;
                    solve[x-1]++;
                }
                else
                {
                    solve[x+1]++;
                    solve[x-1]++;
                }
                solve[x]++;
            });
            Console.WriteLine(solve.Max());
        }

        List<int> Read()
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
    }
}