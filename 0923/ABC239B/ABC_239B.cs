using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC239B
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
            var X = input[0];
            var Y = X / 10;
            // var output = (long)Math.Floor(Y);
            if (X <= 0 && X % 10 != 0) Y -= 1;
            WriteLong(Y);
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
        void WriteLong(long output)
        {
            Console.WriteLine(output);
        }
    }
}