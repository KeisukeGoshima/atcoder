using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC_269B
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
            var input = Enumerable.Range(0, 10).Select(_ => Console.ReadLine()).ToList();
            var X = Enumerable.Range(0, 10).Where(x => input[x].Any(y => y=='#')).Select(x => x+1).ToList();
            var Y = Enumerable.Range(0, 10).Where(x => input[X[0] - 1][x] == '#').Select(x => x+1).ToList();
            Console.WriteLine("{0} {1}", X[0], X[X.Count() - 1]);
            Console.WriteLine("{0} {1}", Y[0], Y[Y.Count() - 1]);
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