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
            var input = ReadLong();
			var mod = 998244353;
            if (input == null) return ;
			if (input.Count != 6) return ;
			var A = input[0];
			var B = input[1];
			var C = input[2];
			var D = input[3];
			var E = input[4];
			var F = input[5];
			var mod_list = input.Select(x => x % mod).ToList();
			var a = mod_list[0];
			var b = mod_list[1];
			var c = mod_list[2];
			var d = mod_list[3];
			var e = mod_list[4];
			var f = mod_list[5];
			var left = ((((a * b) % mod) * c) % mod);
			var right = ((((d * e) % mod) * f) % mod);
			if (left < right) WriteLong(left - right + mod);
			else WriteLong(left - right);
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