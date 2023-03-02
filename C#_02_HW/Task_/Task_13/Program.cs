// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Вывидите трёхзначное число и мы тебе выведем третью цифру заданного числа");
int ThirdDigit(int number);
if (number > 100)
    {
        Console.WriteLine("третьей цифры нет");
    }
else 
    {
        number /= 10;
    }

int result = ThirdDigit(new Random().Next(100, 1000));
Console.WriteLine(result);
