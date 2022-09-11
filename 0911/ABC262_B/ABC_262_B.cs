using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC_262_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = input[0];
            var M = input[1];
            var map_list = new List<List<int>>();
            for (int i=0; i<N+1; i++)
            {
                map_list.Add(new List<int>());
            }
            var count = 0;
            for (int i=0; i < M; i++)
            {
                var map = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                map_list[map[0]].Add(map[1]);
            }
            for (int i=0; i < N; i++)
            {
                if (map_list[i].Count >= 2)
                {
                    for (int j=0; j < map_list[i].Count - 1; j++)
                    {
                        for (int k=j+1; k < map_list[i].Count; k++)
                        {
                            if (map_list[map_list[i][j]].Contains(map_list[i][k])
                            || map_list[map_list[i][k]].Contains(map_list[i][j]))
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}