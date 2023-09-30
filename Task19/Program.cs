// Задача 19: Напишите программу:
// 1. которая принимает на вход пятизначное число
// 2. и проверяет, является ли оно палиндромом.

public class Answer
{
    static bool IsPalindrome(int number)
    {
        string Number = Convert.ToString(number);
        if (Number[0] == Number[4] && Number[1] == Number[3] && Number.Length == 5)
        {
            return true;
        }
        if (Number[0] != Number[4] && Number[1] != Number[3] && Number.Length == 5)
        {
            return false;
        }
        else Console.WriteLine("Число не пятизначное");
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
            number = 234322;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}