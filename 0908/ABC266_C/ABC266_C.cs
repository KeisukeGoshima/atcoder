using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC266C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] B = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] C = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] D = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[][] side = {A, B, C, D};
            
            if (calc_1(side[1][0], side[1][1], side) == calc_1(side[3][0], side[3][1], side))
            {
                Console.WriteLine("No");
            }
            else
            {
                if (calc_2(side[0][0], side[0][1], side) == calc_2(side[2][0], side[2][1], side))
                    Console.WriteLine("No");
                else
                    Console.WriteLine("Yes");
            }
        }

        static int calc_1(int x, int y, int[][] side)
        {
            float a = (side[2][0] - side[0][0]) * (y - side[0][1]) - (side[2][1] - side[0][1]) * (x - side[0][0]);
            if (a > 0)
                return (1);
            else
                return (-1);
        }

        static int calc_2(int x, int y, int[][] side)
        {
            float a = (side[3][0] - side[1][0]) * (y - side[1][1]) - (side[3][1] - side[1][1]) * (x - side[1][0]);
            if (a > 0)
                return (1);
            else
                return (-1);
        }
    }
}