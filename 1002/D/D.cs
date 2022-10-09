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
            var S = input[1];
            var num = 0;
            var abList = Enumerable.Range(0, N).Select(_ => ReadInt()).ToList();
            var HTList = Enumerable.Range(0, N).Select(x => {
                if (abList[x][0] > abList[x][1]){
                    num += abList[x][1];
                    return "T";
                } 
                else
                {
                    num += abList[x][0];
                    return "H";
                }
            }).ToList();
            var divList = Enumerable.Range(0, N).Select(x => {
                var temp = new List<int>();
                temp.Add(Math.Abs(abList[x][0] - abList[x][1]));
                temp.Add(x);
                return temp;
            }).ToList();
            divList = divList.OrderBy(x => x[0]).ToList();
            if (S < num) Console.WriteLine("No");
            else if (S == num) 
            {
                Console.WriteLint("Yes");
                HTList.ForEach(x => Console.Write(x));
            }
            else 
            {
                var div = S - num;
                
            }
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
        void WriteInt(int output)
        {
            Console.WriteLine(output);
        }
        void WriteIntList(List<int> output)
        {
            output.ForEach(x => Console.Write("{0} ", x));
            Console.WriteLine("");
        }
    }
}