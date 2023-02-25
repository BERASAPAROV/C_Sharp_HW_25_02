// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 2 числа и мы тебе скажем какое из них больше");
Console.WriteLine("Введите свое первое число: ");
string s_a = Console.ReadLine()!;
Console.WriteLine("Введите свое первое число: ");
string s_b = Console.ReadLine()!;

int a = int.Parse(s_a);
int b = int.Parse(s_b);

if (a > b)
{
    Console.WriteLine(a);    
}
else if (a == b)
{
    Console.WriteLine($"Числа {a} и {b} равны");
}
else
{
    Console.WriteLine(b);
}