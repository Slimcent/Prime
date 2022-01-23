using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int m, n, i, j;
            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The First Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            int[,] B = new int[10, 10];
            Console.Write("\nEnter The Second Matrix:");
        }
    }
}
