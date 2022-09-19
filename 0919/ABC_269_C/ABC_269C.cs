using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC_269C
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
            var input = ReadLong();
            if (input == null) return ;
            var N = input[0];
            if (N == 0)
            {
                WriteLong(0);
                return ;
            }
            var i = (int)Math.Log(N, 2);
            long standard = (long)Math.Pow(2, i+1);
            var N_bit = Enumerable.Range(0, i+1).Select(x => {
                standard /= 2;
                if (N < standard) return 0;
                else
                {
                    N -= standard;
                    return standard;
                }
            }).ToList();
            var solve = N_bit.Where(x => x != 0).Select(x => x).Reverse().ToList();
            BruteForceSearch(solve);
        }
        void BruteForceSearch(List<long> solve)
        {
            var index = Enumerable.Repeat(0, solve.Count()).ToList();
            var j = 0;
            // indexのbit全探索
            while (true)
            {
                var num = Enumerable.Range(0, solve.Count()).Select(x => index[x] * solve[x]).ToArray().Sum();
                WriteLong(num);
                j = 0;
                while (j < solve.Count())
                {
                    if (index[j] != 1)
                    {
                        index[j] = 1;
                        for (int k = 0; k<j; k++) index[k] = 0;
                        break;
                    }
                    else j++;
                }
                if (j == solve.Count()) break;
            }
        }
        List<long> ReadLong()
        {
            var check = new List<bool>();
            var input = Console.ReadLine().Split(' ').Select(x => {
                long temp = 0;
                check.Add(long.TryParse(x, out temp));
                return temp;
            }).ToList();
            if (check.Any(x => x == false)) return null;
            return input;
        }
        void WriteLong(long solve)
        {
            Console.WriteLine(solve);
        }
    }
}