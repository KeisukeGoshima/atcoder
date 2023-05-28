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
			var M = input[1];
			var misH = H / 10 * 10 + M / 10;
			var misM = H % 10 * 10 + M % 10;
			while (true)
			{
				if ((0 <= misH && misH <= 23) && (0 <= misM && misM <= 59))
					break;
				M += 1;
				if (M == 60)
				{
					M = 0;
					H += 1;
				}
				if (H == 24)
					H = 0;
				misH = H / 10 * 10 + M / 10;
				misM = H % 10 * 10 + M % 10;
			}
			WriteInt(H, false);
			WriteInt(M);
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