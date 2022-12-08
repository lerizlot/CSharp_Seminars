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

// конкатенация (склеивание) строк
string str1 = "Hello";
string str2 = "World";

string str3 = string.Concat(str2, str1," !!! ");

Console.WriteLine(str3);

// вывод в терминал масива из цифр строкой
int[] nums = {1, 2, 3, 4, 5, 6, 7};

string str = string.Join("---", nums);
Console.WriteLine(str);
