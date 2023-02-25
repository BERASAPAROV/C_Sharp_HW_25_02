// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число и мы покажем, все четные значения чисел до: ");
string s_a = Console.ReadLine()!;

int a = int.Parse(s_a);
int i = 2;

Console.WriteLine($"Все четные числа от 1 до {a}");

if(a > 1)
    {
        while (i <= a)
        {
            Console.Write(i + " ");
            i += 2;
        }
    }
