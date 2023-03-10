/* 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0               
*/
int[] array = GetRandomArray(10, 0, 20);
Console.WriteLine(String.Join(", ", array));

int Sum = 0;

for (int i=0; i<array.Length; i++)
{
    Sum += i % 2 == 1 ? array[i] : 0;
}
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {Sum}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
