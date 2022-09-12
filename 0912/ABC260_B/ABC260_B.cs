using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC260_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = input[0];
            var X = input[1];
            var Y = input[2];
            var Z = input[3];
            Student[] student = new Student[N];
            var A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var B = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var solve = new int[X+Y+Z];
            var index = 0;
            for (int i = 0; i < N; i++)
            {
                student[i].number = i+1;
                student[i].math = A[i];
                student[i].english = B[i];
                student[i].sum = A[i] + B[i];
            }
            var solve_X = student.OrderByDescending(x => x.math).Where((x, index) => index < X).Select(x => x.number);
            foreach (int num in solve_X)
            {
                solve[index++] = num;
            } 
            var solve_Y = student.OrderByDescending(x => x.english).Select(x => x.number);
            var count = Y;
            var flag = true;
            foreach (int num in solve_Y)
            {
                flag = true;
                if (count == 0) break;
                for (int i = 0; i < X; i++) if (num == solve[i]) flag = false;
                if (flag)
                {
                    solve[index++] = num;
                    count--;
                }
            }
            var solve_Z = student.OrderByDescending(x => x.sum).Select(x => x.number);
            count = Z;
            foreach (int num in solve_Z)
            {
                flag = true;
                if (count == 0) break;
                for (int i = 0; i < X + Y; i++) if (num == solve[i]) flag = false;
                if (flag)
                {
                    solve[index++] = num;
                    count--;
                }
            }
            var output = solve.OrderBy(x => x);
            foreach (int num in output) Console.WriteLine(num);
        }

        public struct Student
        {
            public int number;
            public int math;
            public int english;
            public int sum;

            public Student(int number, int math, int english, int sum)
            {
                this.number = number;
                this.math = math;
                this.english = english;
                this.sum = sum;
            }
        }
    }
}