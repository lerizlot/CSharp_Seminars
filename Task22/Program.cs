// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= N; i++)
    Console.WriteLine(Math.Pow(i, 2));