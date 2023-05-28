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
			var T = Console.ReadLine().ToList();
			var result = Enumerable.Range(0, S.Count).Select(x => S[x] == T[x]).ToList();
			var mismutch = result.Count(x => x == false);
			if (mismutch == 0) Console.WriteLine("Yes");
			else if (mismutch == 2) {
				var first = result.FindIndex(x => x == false);
				var second = result.FindLastIndex(x => x == false);
				if (second - first != 1) Console.WriteLine("No");
				else {
					if (S[first] == T[second] && S[second] == T[first]) Console.WriteLine("Yes");
					else Console.WriteLine("No");
				}
			}
			else Console.WriteLine("No");
        }

        List<string> ReadStringList(int N=1)
        {
            var input = Enumerable.Range(0, N).Select(_ => Console.ReadLine()).ToList();
            return input;
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
        void WriteInt(int output, bool nextline=true)
        {
			if (nextline==true)
	            Console.WriteLine(output);
			else
				Console.Write("{0} ", output);
        }
        void WriteLong(long output, bool nextline=true)
        {
			if (nextline==true)
	            Console.WriteLine(output);
			else
				Console.Write("{0} ", output);
        }
        void WriteIntList(List<int> output)
        {
            output.ForEach(x => Console.Write("{0} ", x));
            Console.WriteLine("");
        }
    }
}