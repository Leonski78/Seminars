/* Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76
*/
Console.Clear();
int[] array = GetRandomArray(10, 0, 100);
Console.WriteLine(String.Join(", ", array));

int max = array[0];
int min = array[0];

for (int i=0; i<array.Length; i++)
{
    if (array[i]> max)
    {
        max = array[i];
    }
    else if (array[i]<min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}