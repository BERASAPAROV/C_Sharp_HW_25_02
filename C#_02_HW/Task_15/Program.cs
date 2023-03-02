// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void Weekend (int number)
{
    string text = "нет такого дня недели";

    if (number == 7 || number == 6) text = "выходной";
    else if (number < 6 && number > 0) text = "будни";
    Console.WriteLine($"{number} -> {text}");
}

Weekend(int.Parse(Console.ReadLine()!));