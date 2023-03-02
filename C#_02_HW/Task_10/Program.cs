// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Вывидите трёхзначное число и мы тебе на выходе показывает вторую цифру этого числа");
int GetSecondDigit(int number)
{
    Console.WriteLine(number);
    return number / 10 % 10;
}

int result = GetSecondDigit(new Random().Next(100, 1000));
Console.WriteLine($"Вторая цифра этого числа -> {result}");
