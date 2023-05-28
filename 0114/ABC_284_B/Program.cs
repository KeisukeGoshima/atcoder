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
			var T = input[0];
			var solve = new List<int>();
			for (var i=0; i < T; i++)
			{
				input = ReadInt();
				if (input == null) return ;
				var N = input[0];
				input = ReadInt();
				var result = input.Count(x => x % 2 == 1);
				solve.Add(result);
			}
			solve.ForEach(x => WriteInt(x));
        }

        List<char[]> ReadStringList(int N=1)
        {
            var input = Enumerable.Range(1, N).Select(_ => Console.ReadLine().ToCharArray()).ToList();
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