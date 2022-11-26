// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа

Random random = new Random();
int number = random.Next(10, 100);

Console.WriteLine("Random number = {0}", number);
//Console.WriteLine($"Random number = {number}");
//Console.WriteLine("Random number " + number);

int a = number / 10;
int b = number % 10;

if (a > b)
    Console.WriteLine("a > b, {0}", a);
else if (b < a)
    Console.WriteLine("b > a, {0}", b);
else
    Console.WriteLine("b == a, {0}", a);
