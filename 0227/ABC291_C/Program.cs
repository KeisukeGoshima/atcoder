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
			var S = Console.ReadLine().ToList();
			var X = 0;
			var Y = 0;
			var hs1 = new HashSet<String>() {"0,0"};
			var result = S.Select(a => {
				if (a == 'R') X++;
				else if (a == 'L') X--;
				else if (a == 'U') Y++;
				else if (a == 'D') Y--;
				var tmp = X.ToString() + "," + Y.ToString();
				if (hs1.Add(tmp)) return true;
				else return false;
			}).ToList();
			if (result.Any(x => x == false)) Console.WriteLine("Yes");
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
        void WriteIntList(List<int> output)
        {
            output.ForEach(x => Console.Write("{0} ", x));
            Console.WriteLine("");
        }
    }
}