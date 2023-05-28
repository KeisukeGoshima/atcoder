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
			var R = input[0];
			var C = input[1];
			var B = ReadStringList(R);
			var result = Enumerable.Range(0, R).Select(x => {
				var tmp = Enumerable.Range(0, C).Select(y => B[x][y]).ToList();
				return tmp;
			}).ToList();
            var copyresult = Enumerable.Range(0, R).Select(x => {
				var tmp = Enumerable.Range(0, C).Select(y => B[x][y]).ToList();
				return tmp;
			}).ToList();
			var result2 = Enumerable.Range(0, R).Select(x => {
				var tmp = Enumerable.Range(0, C).Select(y => {
					if ('1' <= copyresult[x][y] && copyresult[x][y] <= '9') {
                        var len = (int)(copyresult[x][y] - '0');
                        for (int i=0; i<=len; i++){
                            for (int j=0; j<=len; j++){
                                if (i + j <= len){
                                    if (x+i < R && y+j < C) result[x+i][y+j] = '.';
                                    if (x-i >= 0 && y-j >= 0) result[x-i][y-j] = '.';
                                    if (x-i >= 0 && y+j < C) result[x-i][y+j] = '.';
                                    if (x+i < R && y-j >= 0) result[x+i][y-j] = '.';
                                }
                            }
                        }
                    }
                    return 0;
				}).ToList();
                return tmp;
			}).ToList();
            result.ForEach(x => {
                for (var i=0; i<x.Count; i++){
                    Console.Write(x[i]);
                }
                Console.WriteLine();
            });
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