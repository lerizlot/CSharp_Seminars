// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.WriteLine("Введите день недели");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

switch (DayOfWeek)
{
    case 1:
        Console.WriteLine("It's Monday!");
        break;
    case 2:
        Console.WriteLine("It's Tuesday!");
        break;
    case 3:
        Console.WriteLine("It's Wednesday");
        break;
    case 4:
        Console.WriteLine("It's Thursday");
        break;
    case 5:
        Console.WriteLine("It's Friday");
        break;
    default:
        Console.WriteLine("No Day");
        break;
}