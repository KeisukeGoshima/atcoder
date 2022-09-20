using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC242C
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
            var mod = 998244353;
            var i = 1;
            var solve = Enumerable.Repeat(1, 9).ToList();
            while (i < N)
            {
                var temp = Enumerable.Range(0, 9).Select(x => {
                    if (x == 0) return (solve[x] + solve[x+1]) % mod;
                    if (x == 8) return (solve[x-1] + solve[x]) % mod;
                    else return (solve[x-1] + (solve[x] + solve[x+1]) % mod) % mod;
                }).ToList();
                solve = temp;
                i++;
            }
            var output = 0;
            solve.ForEach(x => output = (output + x) % mod);
            WriteInt(output);
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