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
            var S = Console.ReadLine().Split(' ').ToList();
            if (S.Count == 0) return ;
            var T = Console.ReadLine().Split(' ').ToList();
            if(T.Count == 0) return ;
            var t_idx = 0;
            var result = S.Select(x => {
                while (true)
                {
                    if (x == T[t_idx])
                    {
                        t_idx++;
                        return true;
                    }
                    return false;
                }
            }).ToList();
            result.ForEach(x => {
                if (x) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            });
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