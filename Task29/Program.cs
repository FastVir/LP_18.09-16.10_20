// Задача 29: Напишите программу:
// 1. которая задаёт массив из 8 элементов
// 2. и выводит их на экран.


// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int Promt(string Message)
{
    Console.WriteLine(Message);
     int input = Convert.ToInt32(Console.ReadLine());
    // string input = Console.ReadLine();
    // int result = Convert.ToInt32(input);
    return input;   
}


int length = Promt("Введите количество элементов массива: ");
int min = Promt("Введите минимальное значение: ");
int max = Promt("Введите максимальное значние:");
int[] array = CreateArrayRndInt(length, min, max); 
PrintArray(array);

