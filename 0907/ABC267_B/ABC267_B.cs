using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC267B
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = Console.ReadLine().ToCharArray();
            int[] S = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            for (int i = 0; i <= 9 ; i++)
            {
                if (s[i] == '1')
                    S[i]++;
            }
            int flag = 0;
            int[] row = new int[]
            {
                S[6], S[3], S[7] + S[1], S[4] + S[0], S[8] + S[2], S[5], S[9]
            };
            if (S[0] == 1) Console.WriteLine("No");
            else
            {
                for (int i = 0; i <= 6; i++)
                {
                    if (flag == 2 && row[i] >= 1)
                    {
                        Console.WriteLine("Yes");
                        flag = 3;
                    }
                    else if (flag == 1 && row[i] == 0)
                        flag = 2;
                    else if (flag == 0 && row[i]  >= 1)
                        flag = 1;
                }
                if (flag != 3)
                    Console.WriteLine("No");
            }
        }
        
    }

}

