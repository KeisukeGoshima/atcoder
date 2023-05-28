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
			var A = Enumerable.Range(0, N).Select(_ => ReadInt()).ToList();
			var B = Enumerable.Range(0, N).Select(_ => ReadInt()).ToList();
			var result = Enumerable.Range(0, 4).Select(z => {
				var tmp = Enumerable.Range(1, N).Select(i => {
					var tmp2 = Enumerable.Range(1, N).Select(j => {
						var x = i;
						var y = j;
						for (var itr=0; itr<z; itr++) {
							var tmp3 = x;
							x = N + 1 - y;
							y = tmp3;
						}
						if (A[i-1][j-1] == 1 && B[x-1][y-1] == 1) return 1;
						else if (A[i-1][j-1] == 0) return 1;
						else return 0;
					}).ToList();
					return tmp2;
				}).ToList();
				var tmp4 = tmp.SelectMany(m => m).ToList();
				return tmp4.All(k => k == 1);
			}).ToList();
			if (result.Any(l => l == true)) Console.WriteLine("Yes");
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