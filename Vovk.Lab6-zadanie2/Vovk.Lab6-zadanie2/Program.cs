using System;
namespace Vovk.Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 7;
            int n = 10;
            int[,] matrix = new int[m, n];
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            int mult = 1;
            int sum = 0;
            for (int j = 1; j < matrix.GetLength(1) - j; j++)
                for (int i = 0; i < matrix.GetLength(0); i++)
                    sum += matrix[j, i];
            Console.WriteLine("Сумма элементов второй строки: " + sum);
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1) - j -1 ; j++)
                    mult *= matrix[i, j];
            Console.WriteLine("Произведение элементов первого столбца: " + mult);
        }
    }
}




