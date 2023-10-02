// Задача 27: Напишите программу:
// 1. которая принимает на вход число
// 2. и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System.Globalization;

int SumOfDigit(int num)
{
    int sum = 0;
    // for (int i = num; i > 0; i = i /10)
    // {
    //     sum = sum + i % 10;
    // }
    while(num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum = SumOfDigit(number);
Console.WriteLine($"Сумма цифр в  числе {number} равна {Sum}");
