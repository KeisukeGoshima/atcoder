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
            if (S.Count == 0) return ;
            var front_A_num = S.TakeWhile(x => x == 'a').Count();
            var S_reverse = S.AsEnumerable().Reverse();
            var back_A_num = S_reverse.TakeWhile(x => x == 'a').Count();
            if (front_A_num <= back_A_num)
            {
                var remove_A_num = back_A_num - front_A_num;
                for (var i=0; i<remove_A_num; i++) S.RemoveAt(S.Count - 1);
                var result = Enumerable.Range(0, S.Count / 2).Select(x => S[x] == S[S.Count - 1 - x]).ToList();
                if (result.Any(x => x == false)) Console.WriteLine("No");
                else Console.WriteLine("Yes");
            }
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