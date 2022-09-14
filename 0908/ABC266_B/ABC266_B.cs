using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace ABC266B
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = Console.ReadLine().Split(' ').Select(x => {
                long temp = -1;
                if (long.TryParse(x, out temp)) return temp;
                else
                {
                    Console.WriteLine("不正な値が入力されました");
                    Environment.Exit(-1);
                    return 0;
                }
            });
            // long N = long.Parse(Console.ReadLine());
            int mod = 998244353;
            var solve = N.Select(x => {
                if (x % mod < 0) return x % mod + mod;
                else return x % mod;
            });
            Console.WriteLine(solve.ElementAt(0));
        }
    }
}
