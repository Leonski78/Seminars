    // В двумерном массиве заменить первую строку с последней
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);

Write("Введите первую строку: ");
int a1 = int.Parse(ReadLine());
Write("Введите последнюю строку: ");
int b1 = int.Parse(ReadLine());
WriteLine();
PrintArray(ChangeArray(array, a1, b1));                                 

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

int[,] ChangeArray(int[,] array, int a, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int k = array[a-1, i];
        array [a-1, i] = array [b-1, i];
        array [b-1, i] = k;           
    }
    return array;
}
