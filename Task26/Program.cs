// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите ваше число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1.ToString().Length);

// альтернативное решение

Console.WriteLine("Введите ваше число 2");
string num2 = Console.ReadLine()!;
int count2 = 0;
char[] array = new char[num2.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = num2[i];
    count2++;
}
Console.WriteLine("Количество цифр " +count2);

// решение задачи через цикл while

Console.WriteLine("Введите ваше число 3 ");
int num3 = Convert.ToInt32(Console.ReadLine());
int count3 = 0;
while (num3 > 0)
{
    num3 /= 10;
    count3++;
}

Console.WriteLine(count3);