using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC260_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = input[0];
            int X = input[1];
            int Y = input[2];
            long solve_R_N = 1;
            long solve_R_N_1 = 0;
            long solve_B_N = 0;
            long solve_B_N_1 = 0;
            for (int i=N; i > 1; i--)
            {
                solve_B_N = X * solve_R_N + solve_B_N; 
                solve_R_N_1 = solve_R_N + solve_B_N;
                solve_B_N_1 =  Y * solve_B_N;
                solve_B_N = solve_B_N_1;
                solve_R_N = solve_R_N_1;
            }
            Console.WriteLine(solve_B_N);
        }
    }
}