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
            var a = ReadInt();
            var havebook = Enumerable.Repeat(0, N+1).ToList();
            a.ForEach(x => {
                if (x < N+1) havebook[x] = 1;
            });
            var count = N;
            var now = 1;
            while (count > 0)
            {
                if (havebook[now] == 1) count--;
                else
                {
                    if (count > 1) count -= 2;
                    else break;
                }
                now++;
            }
            WriteInt(now-1);
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