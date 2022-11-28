// Напишите программ, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)

Console.WriteLine($"Введите вашу четверть ");

int quart = Convert.ToInt32(Console.ReadLine());

if (quart == 1)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти X > 0 && Y > 0");
}
else
if (quart == 2)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти X < 0 && Y > 0");
}
else
if(quart == 3)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти X < 0 && Y < 0");
}
else
if (quart == 4)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти X > 0 && Y < 0");
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}


