// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень числа: ");
int B = int.Parse(Console.ReadLine()!);
//Console.WriteLine($"Число {A} в степени {B} равно {GetPow(A)}");
long result = GetPow(A, B);
Console.WriteLine($"Число {A} в степени {B} равно: {GetPow(A, B)} ");

long GetPow(long decis, int rank)
{  
    long result = decis;
    for (int i=1; i<rank; i++){

        decis  *= result;
    }
 return decis;}
 
