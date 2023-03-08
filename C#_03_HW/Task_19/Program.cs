// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите 5 значное число и мы проверим является ли оно палиндромом: ");
string number = Console.ReadLine();

void CheckNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
        {
            Console.WriteLine($"Ваше число: {number} -> да, палиндром");
        }
  else Console.WriteLine($"Ваше число: {number} -> нет, не палиндром");
}

if (number.Length == 5)
    {
        CheckNumber(number);
    }
else Console.WriteLine($"Введено число неудовлетворяющее условие задачи");