using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime;

namespace ABC265C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int H = input[0];
            int W = input[1];
            char[][] map = new char[H][];
            for (int k = 0; k < H; k++)
            {
                map[k] = Console.ReadLine().ToCharArray();
            }
            int i = 0;
            int j = 0;
            while (true)
            {
                if (map[i][j] == 'U')
                {
                    if (i != 0)
                    {
                        map[i][j] = 'x';
                        i -= 1;
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", i+1, j+1);
                        Environment.Exit(0);
                    }
                }
                else if (map[i][j] == 'D')
                {
                    if (i != H - 1)
                    {
                        map[i][j] = 'x';
                        i += 1;
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", i+1, j+1);
                        Environment.Exit(0);
                    }
                }
                else if (map[i][j] == 'L')
                {
                    if (j != 0)
                    {
                        map[i][j] = 'x';
                        j -= 1;
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", i+1, j+1);
                        Environment.Exit(0);
                    }
                }
                else if (map[i][j] == 'R')
                {
                    if (j != W - 1)
                    {
                        map[i][j] = 'x';
                        j += 1;
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", i+1, j+1);
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("-1");
                    Environment.Exit(0);
                }
            }
        }
    }
}