// **Задача 39:** Напишите программу,
//  которая перевернёт одномерный массив 
//  (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

Console.Clear();
int[] array = GetRandomArray(10, 0, 20);
Console.WriteLine(String.Join(", ", array));

int[] ReverseArray(int[] array)
{
    int[] array1 = new int[array.Length];
    for (int i=0; i<array.Length; i++)
    {
         array1[i] = array[array.Length-1-i];
    }
       return array1;
}
Console.WriteLine(String.Join(", ", ReverseArray(array)));

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}