using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	class Square
	{   
         const int N = 8;
         const int M = 8;

            public void Print(int n, int m, int[,] array)
            {
            for(int i = 0; i < n; i++)
             {
             for(int j = 0; j < m; j++)
               Console.WriteLine(array[i, j]);
               Console.WriteLine("\r\n");
             }
            }
            public void SquareWalk()
            {
                int[,] Array = new int[N, M];
                for(int j = 0; j < M; j++)
                Array[0, j] = 1;
                for(int i = 1; i < N; i++)
                {
                Array[i, 0] = 1;
                    for(int j = 1; j < M; j++)
                    Array[i, j] = Array[i, j - 1] + Array[i - 1, j];
                }
                Print(N, M, Array);
            }
        }
    }

