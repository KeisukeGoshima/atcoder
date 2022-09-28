using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC237B
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
            var H = input[0];
            var W = input[1];
            var A = Enumerable.Range(0, H).Select(x => ReadInt()).ToList();
            var B = Enumerable.Range(0, W).Select(x => Enumerable.Range(0, H).Select(y => A[y][x]).ToList()).ToList();
            B.ForEach(x => WriteIntList(x));
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
        void WriteIntList(List<int> output)
        {
            output.ForEach(x => Console.Write("{0} ", x));
            Console.WriteLine("");
        }
    }
}