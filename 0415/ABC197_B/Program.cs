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
            if (input == null) return;
            var H = input[0];
            var W = input[1];
            var X = input[2];
            var Y = input[3];
            var S = ReadStringList(H);
            var result = 0;
            for (int i = Y - 1; i < W; i++)
            {
                if (S[X - 1][i] == '#') break;
                else result++;
            }
            for (int i = Y - 1; i >= 0; i--)
            {
                if (S[X - 1][i] == '#') break;
                else result++;
            }
            for (int i = X - 1; i < H; i++)
            {
                if (S[i][Y - 1] == '#') break;
                else result++;
            }
            for (int i = X - 1; i >= 0; i--)
            {
                if (S[i][Y - 1] == '#') break;
                else result++;
            }
            if (S[X - 1][Y - 1] == '.') result -= 3;
            WriteInt(result);
        }

        List<List<char>>? ReadStringList(int N = 1)
        {
            var input = Enumerable.Range(0, N).Select(_ => Console.ReadLine()?.ToList()).ToList();
            return input;
        }

        List<int>? ReadInt()
        {
            var check = new List<bool>();
            var input = Console.ReadLine()?.Split(' ').Select(x =>
            {
                var temp = 0;
                check.Add(int.TryParse(x, out temp));
                return temp;
            }).ToList();
            if (check.Any(x => x == false)) return null;
            return input;
        }

        List<long>? ReadLong()
        {
            var check = new List<bool>();
            var input = Console.ReadLine()?.Split(' ').Select(x =>
            {
                long temp = 0;
                check.Add(long.TryParse(x, out temp));
                return temp;
            }).ToList();
            if (check.Any(x => x == false)) return null;
            return input;
        }

        void WriteInt(int output, bool nextline = true)
        {
            if (nextline == true)
                Console.WriteLine(output);
            else
                Console.Write("{0} ", output);
        }

        void WriteLong(long output, bool nextline = true)
        {
            if (nextline == true)
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
