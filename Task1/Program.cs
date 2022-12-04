// Задача №1. Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");

int b = Convert.ToInt32(Console.ReadLine());

if ( b * b == a)
    Console.WriteLine("Число a является квадратом числа b");
else
    Console.WriteLine("Число a не является квадратом числа b");

int SayPlus(int n1, int n2)
{
    int x = n1 + n2;
    return x;
}

int x1 = SayPlus(2, 3);
Console.WriteLine(x1);

int x2 = SayPlus(21, 23);
Console.WriteLine(x2);

int x3 = SayPlus(12, 45);
Console.WriteLine(x3);
