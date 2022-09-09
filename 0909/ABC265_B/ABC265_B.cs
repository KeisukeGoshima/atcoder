using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace ABC265B
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long N = input[0];
            long M = input[1];
            long T = input[2];
            var A = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            for (int i=0; i<M; i++)
            {
                long[] tmp = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                A[tmp[0] - 1] -= tmp[1];
            }
            var solve = A.Select(x => 
            {
                T -= x;
                return T;
            }).Where(x => x <= 0);
            if (!solve.Any()) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            // for (int i=0; i<N - 1; i++)
            // {
            //     T -= A[i];
            //     if (T <= 0)
            //     {
            //         Console.WriteLine("No");
            //         Environment.Exit(0);
            //     }
            // }
        }
    }
}