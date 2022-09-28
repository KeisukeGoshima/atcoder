using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC270B
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
            var X = input[0];
            var Y = input[1];
            var Z = input[2];
            if (0 < Y && Y < X)
            {
                if (0 < Z && Z < Y) WriteInt(X); // 0 Z Y X
                else if (Z < 0) WriteInt(X-2*Z); // Z 0 Y X
                else WriteInt(-1); // 0 Y (Z X)
            }
            else if (X < Y && Y < 0)
            {
                if (Y < Z && Z < 0) WriteInt(-X); // X Y Z 0
                else if (Z > 0) WriteInt(-X+2*Z); // X Y 0 Z
                else WriteInt(-1); // (X Z) Y 0
            }
            else WriteInt(Math.Abs(X));
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
    }
}