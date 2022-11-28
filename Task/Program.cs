/* string[] names = {"Bob", "Liz", "John", "Ann", "Sara"};
Console.WriteLine(names[3]);

Console.WriteLine($"Новое имя {names[3]}");

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
*/

Console.Write($"Введите количество чисел ");
int num = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[num];

// 
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(1, 100);
}
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"{nums[i]} ");
}

/*
x = квадратный корень из y
x = Math.Sqrt(y);

возведение в степень
x = Math.Pow(y, 3);

округлить дробное число
x = Math.Round(y, 3);
*/