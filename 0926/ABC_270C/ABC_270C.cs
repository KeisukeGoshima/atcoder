using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC_270C
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
            var X = input[1];
            var Y = input[2];
            var U_V_list = Enumerable.Range(0, N-1).Select(_ => ReadInt()).ToList();
            var tree = Enumerable.Range(0, N+1).Select(x => U_V_list.Where(y => y[0] == x || y[1] == x).Select(z => {
                if (z[0] == x) return z[1];
                else return z[0];
            }).ToList()).ToList();
            var ans = DepthFirstSearch(tree, X, Y, N);
            ans.ForEach(x => WriteInt(x));
        }
        List<int> DepthFirstSearch(List<List<int>> tree, int start, int finish, int N)
        {
            var ans = new List<int>();
            var flag = Enumerable.Range(0, N+1).Select(_ => false).ToList();
            var temp = new List<int>();
            var now = start;
            ans.Add(start);
            flag[start] = true;
            while (now != finish)
            {
                temp = tree[now].Where(x => flag[x] == false).Select(x => x).Take(1).ToList();
                if (temp.Count != 0)
                {
                    now = temp[0];
                    flag[now] = true;
                    ans.Add(now);
                }
                else
                {
                    ans.RemoveAt(ans.Count - 1);
                    now = ans[ans.Count - 1];
                }
            }
            return ans;
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
            Console.Write("{0} ", output);
        }
    }
}