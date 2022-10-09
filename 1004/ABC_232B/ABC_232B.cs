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
            var S = Console.ReadLine().ToList();
            if (S == null) return ;
            var T = Console.ReadLine().ToList();
            if(T == null) return ;
            if (S.Count != T.Count) 
            {
                Console.WriteLine("No");
                return ;
            }
            var div = (int)T[0] - (int)S[0];
            var result = Enumerable.Range(0, S.Count).Select(x => (int)T[x] - (int)S[x]).ToList();
            WriteInt(result.Count);
            if (result.All(x => x == result[0])) Console.WriteLine("Yes");
            else Console.WriteLine("No");
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