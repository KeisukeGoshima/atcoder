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
			var H = input[0];
			var W = input[1];
			var A = Enumerable.Range(0, H).Select(_ => Console.ReadLine().ToList()).ToList();
			var B = Enumerable.Range(0, H).Select(_ => Console.ReadLine().ToList()).ToList();
			var result = Enumerable.Range(0, H).Select(x => {
				var tmp = Enumerable.Range(0, W).Select(y => {
					for (int i = 0; i < H; i++)
					{
						var tmpx = 0;
						for (int j = 0; j < W; j++)
						{
							var tmpy = 0;
							if (i+x >= H) tmpx = -H;
							if (j+y >= W) tmpy = -W;
							if (A[i+x+tmpx][j+y+tmpy] != B[i][j]) return 0;
						}
					}
					return 1;
				}).ToList();
				if (tmp.All(z => z == 0)) return 0;
				else return 1;
			}).ToList();
			if (result.All(x => x == 0)) Console.WriteLine("No");
			else Console.WriteLine("Yes");
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
        List<long> ReadLong()
        {
            var check = new List<bool>();
            var input = Console.ReadLine().Split(' ').Select(x => {
                long temp = 0;
                check.Add(long.TryParse(x, out temp));
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