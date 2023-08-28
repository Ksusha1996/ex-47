// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов (n): ");
        int n = int.Parse(Console.ReadLine());

        double[,] array = new double[m, n];
        Random random = new Random();

        Console.WriteLine("Двумерный массив:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble() * 20 - 10; // Генерация случайного вещественного числа от -10 до 10
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
