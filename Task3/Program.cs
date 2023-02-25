/***Задача 35:**Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5*/

var fibonacciNumbers = new List<int> {1, 1, 2, 3, 5, 8, 13, 21};
var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 4];

fibonacciNumbers.Add(previous + previous2);

foreach(var item in fibonacciNumbers)
    Console.WriteLine(item);
