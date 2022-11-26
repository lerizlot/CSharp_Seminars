// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно числам 7 и 23

Console.WriteLine("Введите ваше число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
    Console.WriteLine($"Число {number} кратно числам 7 и 23");
else 
    Console.WriteLine("Нет");
