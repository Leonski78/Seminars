// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();
// Console.Write("Введите число 1: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число 2: ");
// int B = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число 3: ");
// int C = int.Parse(Console.ReadLine()!);


// if ((A+B)>C && (A+C)>B && (B+C)>A)
// {
//     Console.WriteLine("Такой треугольник существует");
// }
// else
// Console.WriteLine("Такой треугольник не существует");

Console.Write("Введите стороны треугольника через пробел: ");

string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int a = int.Parse(st[0]);
int b = int.Parse(st[1]);
int c = int.Parse(st[2]);

if (IsTriangle(a,b,c))
{
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}

bool IsTriangle(int a, int b, int c){
    return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
}
