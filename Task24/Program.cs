// Задача 24: Напишите программу:
// 1. которая принимает на вход число (А)
// 2. и выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i < num; i++)
    {
        checked  // проверяет на переполнение типа(в данном случае int32 имеет ограниченное кол-во цифр, 
                 // если ввести большое число то оно обрежется и выведется не верное значение)
                 // Будет похожая ошибка с cheked: Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
                 // at Program.<<Main>$>g__SumNumbers|0_0(Int32 num) in C:\Users\DarGoD\Desktop\Workspace\Task24\Program.cs:line 16
                 // at Program.<Main>$(String[] args) in C:\Users\DarGoD\Desktop\Workspace\Task24\Program.cs:line 26
        {
        sum+=i;
        }
    }
    return sum;
}


Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");
