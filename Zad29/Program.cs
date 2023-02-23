//30 Напишите программу, которая выводит массив из N элементов, 
//заполненный любыми натуральными числами до Max -> Next(Max)

//[1,0,1,1,0,1,0,0] - бинарный вариант
// a = new Random().Next()
// int a = new Random().Next(2)

Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int[] array = GetArray(N);
// первый вариант вывода массива:
Console.WriteLine($"[{String.Join(", " , array)}]");
// второй вариант вывода массива:
for (int i = 0; i < N-1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write($"{array[N-1]}");

int[] GetArray (int size)
{
    int[] result = new int [size];
    for (int i =0; i < size; i ++)
    {
        result[i] = new Random ().Next(1000);
    }
        return result;
}
