// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());

if (a / b == b || b / a == a)
    Console.WriteLine("Число a является квадратом числа b, или число b является квадратом числа a");
else
    Console.WriteLine("Ни одно число не является квадратом другого");
