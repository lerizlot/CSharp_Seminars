// Задача №5. Напишите программу,
// которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке
// от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

for( int P = -N; P < N; P++)
{
    Console.WriteLine(P);
};
Console.WriteLine(N);

// альтернативное решение

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
for (int n_opposite = -n; n_opposite <= n; n_opposite++)
{
    Console.WriteLine(n_opposite);
}
else 
for (int n_opposite = n; n_opposite <= -n; n_opposite++)
{
    Console.WriteLine(n_opposite);
}