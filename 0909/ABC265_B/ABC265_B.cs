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
            long[] input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long N = input[0];
            long M = input[1];
            long T = input[2];
            long[] A = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] X = new long[M];
            long[] Y = new long[M];
            for (int i=0; i<M; i++)
            {
                long[] tmp = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                X[i] = tmp[0];
                Y[i] = tmp[1];
            }
            int idx = 0;
            for (int i=0; i<N - 1; i++)
            {
                if (M != 0 && i + 1 == X[idx])
                {
                    T += Y[idx];
                    if (idx < M - 1)
                        idx++;
                }
                T -= A[i];
                if (T <= 0)
                {
                    Console.WriteLine("No");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Yes");
        }
    }
}