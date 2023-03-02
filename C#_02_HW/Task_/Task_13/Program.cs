// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Вывидите трёхзначное число и мы тебе выведем третью цифру заданного числа");
void ThirdDigit(int number)
{
    Console.Write($"{number} -> ");
    if (number < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return;
    }

    while (number > 999) number /= 10;
    Console.WriteLine($"третья цифра заданного числа -> {number % 10}");
}

ThirdDigit(int.Parse(Console.ReadLine()!));