// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X ≠ 0 и Y ≠ 0 и выдает номер четверти плоскости, в которой находится эта точка.
Console.Write($"Введите X ");
double X = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите Y ");
double Y = Convert.ToDouble(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("1-я четверть");
}
else
if (X < 0 && Y > 0)
{
    Console.WriteLine("2-я четверть");
}
else
if (X < 0 && Y < 0)
{
    Console.WriteLine("3-я четверть");
}
else
if (X > 0 && Y < 0)
{
    Console.WriteLine("4-я четверть");
}


