//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
int[] array = GetArray(12);
Console.WriteLine($"[{String.Join(", ", GetArray(12))}]");
int size = 12;
Console.WriteLine("Сумма отрицательных элементов: ");
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i<size; i++)
    {
        result[i]=new Random().Next(-9, 10);
    }
    return result;
}
int[] GetSum(int[]result)
{
    int Sum1 = 0;
    int Sum2 = 0;
    for (int i=0; i<size; i++)
    
}

