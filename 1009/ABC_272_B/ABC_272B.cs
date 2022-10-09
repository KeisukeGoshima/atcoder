using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
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
            var M = input[1];
            var k = Enumerable.Range(0, M).Select(_ => ReadInt()).ToList();
            var result = Enumerable.Range(0, N).Select(_ => Enumerable.Repeat(0, N).ToList()).ToList();
            k.ForEach(x => {
                for (int i=1; i<=x[0]; i++)
                    for (int j=1; j<=x[0]; j++)
                        result[x[i] - 1][x[j] - 1] = 1;
            });
            var check = false;
            result.ForEach(x => {
                if (x.Any(y => y == 0)) check = true;
            });
            if (check) Console.WriteLine("No");
            else Console.WriteLine("Yes");
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
        void WriteIntList(List<int> output)
        {
            output.ForEach(x => Console.Write("{0} ", x));
            Console.WriteLine("");
        }
    }
}