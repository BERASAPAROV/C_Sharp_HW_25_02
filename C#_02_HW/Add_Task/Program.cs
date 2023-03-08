// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру


Console.WriteLine("Вывидите трёхзначное число и мы удалим вторую цифру");
int DelSecondDigit(int number)
{
    Console.WriteLine(number);
    return number / 100 * 10 + number % 10;
}

int result = DelSecondDigit(new Random().Next(100, 1000));
Console.WriteLine($"Результат этого числа -> {result}");
