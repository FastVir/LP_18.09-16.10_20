// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int NumberInput(string message)
// {
//     Console.Write(message);
//     string ReadInput = Console.ReadLine();
//     int result = int.Parse(ReadInput);
//     return result;

// }




int[] GenerateArray(int lenght)
{
    
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int PositiveNumbersArray(int[] arr)
{
    count = 0;  //0, 7, 8, -2, -2 -> 2
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}



Console.WriteLine("Введите длину массива:");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] array = GenerateArray(5);
PrintArray(array);

