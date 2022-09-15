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
            List<bool> check = new List<bool>();
            var N = Console.ReadLine().Split(' ').Select(x => {
                long temp = 0;
                check.Add(long.TryParse(x, out temp));
                return temp;
            }).ToList();
            if (check.Any(x => x == false))
            {
                Console.WriteLine("不正な値が入力されました");
                return ;
            }
            int mod = 998244353;
            var solve = N.Select(x => {
                if (x % mod < 0) return x % mod + mod;
                else return x % mod;
            }).ToList();
            Console.WriteLine(solve[0]);
        }
    }
}
