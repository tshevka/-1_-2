using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛАБ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть розмір матриці: ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<int> R = new List<int>();
            int[,] A = new int[N, N];
            int[,] B = new int[N, N];

            Random rnd = new Random();


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = rnd.Next(0, 100);
                    B[i, j] = rnd.Next(0, 100);
                }
            }


            Console.WriteLine("Початкова матриця А: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Початкова матриця B: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(B[i, j] + "  ");
                }
                Console.WriteLine();
            }



            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] == B[i, j])
                    {
                        R.Add(A[i, j]);
                    }
                }
            }

            Console.Write("Введите s: ");
            int s = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 0;

            int count = 1;
            int scounter = 0;
            for (int i = 0; i < R.Count; i++)
            {
                if (R[i] == s)
                {
                    scounter++;
                    if (count == 1)
                    {
                        a = i;
                        b = i;
                    }
                    else 
                    {
                        b = i;
                    }
                }
            }

            if (scounter > 1)
            {
                A[a % N, b % N] = s;
            }
            else 
            {
                B[b % N, a % N] = s;
            }

           

            Console.WriteLine("Масив R: ");
            for (int i = 0; i < R.Count; i++)
            {
                Console.Write(R[i] + "  ");
            }

            Console.WriteLine();
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            

            Console.WriteLine("Кінцева матриця А: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Кінцева матриця B: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(B[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
