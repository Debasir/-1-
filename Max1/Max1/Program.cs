using System;

namespace Max1
{
    class Program
    {
        static int[,] Build_rand_squere_matrix(int matrix_size)
        {
            int n = matrix_size;

            int[,] matrix = new int[n, n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = rnd.Next(-10, 0);

            return matrix;

        }
        static void Print_2arr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        static void Print_arr(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static int[] getLine(int[,] arr, int line_number)
        {
            int[] line = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == line_number)
                    {
                        line[j] = arr[i, j];
                    }
                }
            }
            return line;
        }

        static int findLineWithMaxElement(int[,] arr)
        {
            int lineNumber = -1;
            int max = -10;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j && arr[i, j] > max)
                    {
                        max = arr[i, j];
                        lineNumber = i;

                    }
                }
            }
            return lineNumber;
        }
        static void Main(string[] args)
        {
            int[,] arr = Build_rand_squere_matrix(5);
            Print_2arr(arr);
            Console.WriteLine(findLineWithMaxElement(arr));
            Print_arr(getLine(arr, findLineWithMaxElement(arr)));
        }
    }
}
