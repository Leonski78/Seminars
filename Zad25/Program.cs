// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень числа: ");
int B = int.Parse(Console.ReadLine()!);
//Console.WriteLine($"Число {A} в степени {B} равно {GetPow(A)}");
int result = GetPow(A);
Console.WriteLine($"Число {A} в степени {B} равно: {result} ");

int GetPow(int result)
{   
    result = Math.Pow(A,B);
}
 return result;
 
 
