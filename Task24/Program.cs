// Напишите программу, которая принимает на вход чиисло (A) и выдаёт сумму чисел от 1 до A
// 7 -> 28
// 4 -> 10
// 8 -> 36 

Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int B = 1; B <= A; B++)
{  
    sum = sum + B;
}

Console.WriteLine(sum);
