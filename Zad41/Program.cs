// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
// Console.Write("Введите числа через пробелы: ");
// // Console.WriteLine(String.Join(", ", array));
// string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// st = new string[st.Length];
// int count = 0;

// for (int i=0; i<st.Length; i++)
// {
//     if (st[i] > 0) 
//     count++;
// }
// Console.WriteLine($"количество чисел > 0 равно: {count}");

int Prompt (string message)
{
Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}
int[] InputArray(int length)
{
    int[] array = new int [length];
    for (int i=0; i<array.Length; i++)
    {
        array [i] = Prompt($"Введите {i + 1}-й элемент ");
    }
    return array;
}
void PrintArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.WriteLine($"а[{i}] = {array [i]}");
    }
}
int CountPositiveNumbers(int[]array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array [i]>0)
        {
            count ++;
        }
    }
    return count;
}
int leng = Prompt ("Введите количество элементов >");
int [] array;
array = InputArray(leng);
PrintArray(array);
Console.WriteLine($"Колиество чисел больше 0 = {CountPositiveNumbers(array)}");

/*2-й вариант
using System;
using static System.Console;

Write("Введите числа через пробел: ");
int[] numbers = GetArrayFromString(ReadLine());
WriteLine($"Количество чисел больше 0 –> {GetCountPositiveElements(numbers)}");
WriteLine();


int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

int GetCountPositiveElements(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if(item>0) count++;
    }
    return count;
}*/
