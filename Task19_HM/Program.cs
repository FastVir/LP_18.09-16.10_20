// Задача 19: Напишите программу:
// 1. которая принимает на вход пятизначное число
// 2. и проверяет, является ли оно палиндромом.

using System.Diagnostics.CodeAnalysis;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        string Number = Convert.ToString(number);
        if (Number.Length != 5)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        };
        return Number[0] == Number[4] && Number[1] == Number[3];

    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 12324;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}