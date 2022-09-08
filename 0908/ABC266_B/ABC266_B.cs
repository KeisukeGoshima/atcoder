using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC266B
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            int mod = 998244353;
            while (N < 0)
            {
                N += mod;
            }
            N %= mod;
            Console.WriteLine(N);
        }
    }
}
