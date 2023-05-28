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
			var S = Enumerable.Range(1, M).Select(x => ReadInt()).ToList();
			var result = Enumerable.Repeat(0, N+1).ToList();
			var tmp = S.Select(x => {
				if (result[x[1]] == 0) result[x[1]] = 1;
				else result[x[0]] = 1;
				return 0;
			}).ToList();
			WriteInt(result.Count(x => x == 0) - 1);
        }

        List<string> ReadStringList(int N=1)
        {
            var input = Enumerable.Range(1, N).Select(_ => Console.ReadLine()).ToList();
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
        void WriteIntList(List<int> output)
        {
            output.ForEach(x => Console.Write("{0} ", x));
            Console.WriteLine("");
        }
    }
}