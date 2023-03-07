// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());

double[,] array = GetArray(m, n, 0, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]:f2} ");
        }
        WriteLine();
    }
}
