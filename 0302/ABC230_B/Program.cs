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
            // var input = ReadInt();
            // if (input == null) return ;
			var S = Console.ReadLine().ToList();
			var check_iscircle = Enumerable.Range(0, S.Count).Where(x => S[x] == 'o').Select(x => x).ToList();
			S.Reverse();
			var check_backIsOk = S.TakeWhile(x => x == 'x').Select(x => x).ToList();
			if (check_iscircle.Count >= 1) {
				var first = check_iscircle[0];
				if (3 <= first || check_backIsOk.Count > 2) Console.WriteLine("No");
				else {
					var tmp = first;
					var isok = true;
					check_iscircle.ForEach(x => {
						if (first == x) ;
						else if (x - tmp == 3) tmp = x;
						else isok = false;
					});
					if (isok) Console.WriteLine("Yes");
					else Console.WriteLine("No");
				}
			}
			else {
				if (check_backIsOk.Count > 2) Console.WriteLine("No");
				else Console.WriteLine("Yes");
			}
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