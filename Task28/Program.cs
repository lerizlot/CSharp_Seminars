// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int res = 1;

for (int B = 1; B <= N; B++)
{  
    res = res * B;
}

Console.WriteLine(res);