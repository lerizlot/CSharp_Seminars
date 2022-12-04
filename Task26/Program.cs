// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите ваше число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num.ToString().Length);

// альтернативное решение

Console.WriteLine("Введите ваше число 2");
string number = Console.ReadLine();
int count = 0;
char[] array = new char[number.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = number[i];
    count++;
}
Console.WriteLine("Количество цифр " +count);