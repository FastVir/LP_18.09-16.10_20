// Задача 26: Напишите программу:
// 1. которая принимает на вход число
// 2. и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

using System.Globalization;

int lenghtDigit(int num)
{
    if (num == 0) return 1;
    string Number = Convert.ToString(num);
    if (Number[0] == '-')
    {
        string Numb = Number.Remove(0, 1);
        return Numb.Length;
    }
    return Number.Length;
}


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int LenghtNumber = lenghtDigit(number);
Console.WriteLine($"Количество цифр в {number} = {LenghtNumber}");



