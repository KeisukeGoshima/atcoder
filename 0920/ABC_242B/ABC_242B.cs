using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC242B
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Solve();
        }

        void Solve()
        {
            var input = Console.ReadLine().Select(x => x).ToList();
            var output = input.OrderBy(x => x).ToList();
            output.ForEach(x => Console.Write(x));
        }
    }
}