// Задача №11. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа

Random random = new Random();
int number = random.Next(100, 1000);

Console.WriteLine(number);

int a = number / 100;
int b = number % 10;

Console.WriteLine("Необходимое число = " +a +b);

// альтернативное решение
Console.WriteLine($"Random number = {number}");
int delete = 2;
// превращаем число в строку
var str = number.ToString();
//возвращаем из строки в число
number = int.Parse(str.Remove(str.Length - delete, 1));
// метод Remove говорит: удали с первого индекса один символ.  
Console.WriteLine("Answer = " +number);




