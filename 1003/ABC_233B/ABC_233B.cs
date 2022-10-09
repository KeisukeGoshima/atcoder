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
            var L = input[0];
            var R = input[1];
            var S = Console.ReadLine().ToList();
            var subject = S.Where((x, index) => index >= L - 1 && index <= R - 1).Select(x => x).ToList();
            subject = subject.AsEnumerable().Reverse().ToList();
            for (int i=0; i < S.Count; i++)
            {
                if (L-1 <= i && i <= R-1) Console.Write(subject[i-(L-1)]);
                else Console.Write(S[i]);
            }

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