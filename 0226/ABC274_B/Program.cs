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
			var H = input[0];
			var W = input[1];
			var S = ReadStringList(H);
			var result = Enumerable.Range(0, W).Select(x => S.Count(y => y[x] == '#')).ToList();
			WriteIntList(result);
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