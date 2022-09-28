using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC_238B
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
            var temp = 0;
            var cutPosition = Enumerable.Range(0, N).Select(x => {
                temp += A[x];
                if (temp >= 360) temp %= 360;
                return temp;
            }).ToList();
            cutPosition.Add(0);
            cutPosition = cutPosition.OrderBy(x => x).ToList();
            var pizaRange = Enumerable.Range(0, N+1).Select(x => {
                if (x == N) return 360 - cutPosition[x];
                else return cutPosition[x+1] - cutPosition[x];
            }).OrderByDescending(x => x).ToList();
            WriteInt(pizaRange[0]);

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