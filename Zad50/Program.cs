// Задача 50. //Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает информацию о наличии этого элемента в массиве.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

int[,] array = GetArray(rows, columns,0,10);
PrintArray(array);
WriteLine();
Write("Введите число: ");
int a = int.Parse(ReadLine());
string result = FindArray(array, a);
WriteLine(result);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }

    }
    return result;
}

// void FindArray(int[,] result, int a)
// {
//     // int[,] result = new int[i, j];
//         for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         { 
//             if (result[i, j] == a)
//             {
//                 Write($"Число {a} найдено");
//             }
//             else
//             {
//                 Write($"Число {a} не найдено");
//             }
//         }
//     }
//     // return result;
// }

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}
string FindArray(int[,] result, int a)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            if (result[i, j] == a)
            {
                return  "найдено";
            }
        }
    }
    return   "не найдено";
}