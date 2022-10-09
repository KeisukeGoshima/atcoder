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
            var xyList = Enumerable.Range(0, N).Select(_ => ReadInt()).ToList();
            double maxDistance = 0;
            var result = Enumerable.Range(0, N-1).Select(x => 
            Enumerable.Range(x, N-x).Select(y => {
                var distance = calcDistance(xyList[x], xyList[y]);
                if (maxDistance < distance) maxDistance = distance;
                return distance;
            }).ToList()).ToList();
            WriteDouble(maxDistance);
        }
        double calcDistance(List<int> a, List<int> b)
        {
            var x = Math.Abs(b[0] - a[0]);
            var y = Math.Abs(b[1] - a[1]);
            return Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2));
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

        void WriteDouble(double output)
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