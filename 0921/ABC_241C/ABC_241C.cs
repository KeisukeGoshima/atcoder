// using System;
// using System.Linq;
// using System.Collections.Generic;

// namespace ABC_241C
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var program = new Program();
//             program.solve();
//         }
//         void solve()
//         {
//             var input = ReadInt();
//             var N = input[0];
//             var S = Enumerable.Range(0, N).Select(_ => Console.ReadLine().ToList()).ToList();
//             var flag = 0;
//             //横
//             for (int i=0; i<N; i++)
//             {
//                 var num = 0;
//                 var result = Enumerable.Range(0, N).Select(x => {
//                     if (S[i][x] == '#') num += 1;
//                     if (x >= 6 && S[i][x - 6] == '#') num -= 1;
//                     if (num >= 4) flag = 1;
//                     return 1;
//                 }).ToList();
//             }
//             //縦
//             for (int i=0; i<N; i++)
//             {
//                 var num = 0;
//                 var result = Enumerable.Range(0, N).Select(x => {
//                     if (S[x][i] == '#') num += 1;
//                     if (x >= 6 && S[x - 6][i] == '#') num -= 1;
//                     if (num >= 4) flag = 1;
//                     return 1;
//                 }).ToList();
//             }
//             //右斜め
//             for (int i=0; i<N; i++)
//             {
//                 var num = 0;
//                 var result = Enumerable.Range(0, N).Select(x => {
//                     if (x+i < N && S[x+i][x+i] == '#') num += 1;
//                     if (x >= 6 && x+i-6 < N && S[x+i-6][x+i-6] == '#') num -= 1;
//                     if (num >= 4) flag = 1;
//                     return 1;
//                 }).ToList();
//             }
//             //左斜め
//             for (int i=0; i<N; i++)
//             {
//                 var num = 0;
//                 var result = Enumerable.Range(0, N).Select(x => {
//                     if (x+i < N && S[x+i][x+i] == '#') num += 1;
//                     if (x >= 6 && x+i-6 < N && S[x+i-6][x+i-6] == '#') num -= 1;
//                     if (num >= 4) flag = 1;
//                     return 1;
//                 }).ToList();
//             }
//             if (flag == 1) Console.WriteLine("Yes");
//             else Console.WriteLine("No");
//         }
//         List<int> ReadInt()
//         {
//             var check = new List<bool>();
//             var input = Console.ReadLine().Split(' ').Select(x => {
//                 var temp = 0;
//                 check.Add(int.TryParse(x, out temp));
//                 return temp;
//             }).ToList();
//             if (check.Any(x => x == false)) return null;
//             return input;
//         }
//         void WriteInt(int output)
//         {
//             Console.WriteLine(output);
//         }
//     }
// }