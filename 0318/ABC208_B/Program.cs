﻿using System;
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
			var P = input[0];
			var tmp = 1;
			var coin = Enumerable.Range(1, 10).Select(x => {
				tmp = tmp * x;
				return tmp;
			}).ToList();
			var result = 0;
			coin.Reverse();
			coin.ForEach(x => {
				while (P >= x && P != 0)
				{
					result++;
					P -= x;
				}
			});
			Console.WriteLine(result);
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