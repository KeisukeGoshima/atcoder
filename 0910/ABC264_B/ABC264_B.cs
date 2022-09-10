using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime;

namespace ABC264_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int R = input[0];
            int C = input[1];
            // int distance = Math.Max(Math.Abs(8 - R), Math.Abs(8 - C));
            var distance = input.Select(x => Math.Abs(8 - x)).Max();
            if (distance % 2 == 0) Console.WriteLine("white");
            else Console.WriteLine("black");
        }
    }
}