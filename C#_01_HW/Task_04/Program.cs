// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа и мы тебе скажем какое из них больше");
Console.WriteLine("Введите свое первое число: ");
string s_a = Console.ReadLine()!;
Console.WriteLine("Введите свое второе число: ");
string s_b = Console.ReadLine()!;
Console.WriteLine("Введите свое второе число: ");
string s_c = Console.ReadLine()!;

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);

if (a > b && a > c) 
{
    Console.WriteLine($"Число с максимальным значение - {a}");
} 
else if (b > a && b > c) 
{ 
    Console.WriteLine($"Число с максимальным значение - {b}");
} 
else if (c > a && c > b) 
{ 
    Console.WriteLine($"Число с максимальным значение - {c}");
}
