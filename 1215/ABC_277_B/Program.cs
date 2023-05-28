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
            var S = ReadStringList(N);
			char[] check = {'H', 'D', 'C', 'S'};
			char[] check2 = {'A', '2', '3' , '4' , '5' , '6' , '7' , '8' , '9' , 'T' , 'J' , 'Q' , 'K' };
			var result = S.Select(x => check.Any(y => y == x[0])).ToList();
			var result2 = S.Select(x => check2.Any(y => y == x[1])).ToList();
			var result3 = S.Select(x => S.Count(y => x[0] == y[0] && x[1] == y[1]) == 1).ToList();
			if (!result.Any(x => x == false) && !result2.Any(x => x == false) && !result3.Any(x => x == false)) Console.WriteLine("Yes");
			else Console.WriteLine("No");
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