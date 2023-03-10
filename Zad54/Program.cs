﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
int[,] arr = ChangeArray(array);
PrintArray(arr);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

// int[] GetRowArray(int[,] inArray)
// {
//     int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
//     int index = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             result[index] = inArray[i, j];
//             index++;
//         }
//     }
//     return result;
// }

int[,] ChangeArray(int[,] array)
{
    int[,] result1 = new int [array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
        {   
                if (result1[i, j] > array[i, j])
            {
                int k = result1[i, j];
                result1[i, j] = array[i, j];
                array[i, j] = k;
            }
        }
    }
    return result1;
}

// void SortArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         for (int j = i + 1; j < inArray.Length; j++)
//         {
//             if (inArray[i] > inArray[j])
//             {
//                 int k = inArray[i];
//                 inArray[i] = inArray[j];
//                 inArray[j] = k;
//             }
//         }
//     }
// }


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

// void PrintData(int[] inArray)
// {
//     int el = inArray[0];
//     int count = 1;
//     for (int i = 1; i < inArray.Length; i++)
//     {
//         if (inArray[i] != el)
//         {
//             WriteLine($"{el} встречается {count}");
//             el = inArray[i];
//             count = 1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     WriteLine($"{el} встречается {count}");
// }