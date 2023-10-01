// Задача 30: Напишите программу:
// 1. которая выводит массив из 8 элементов,
// 2. заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

// int[] array1 = new int[8] {4,7,8,9,3,1,4,1};
// int[] array2 = new int[] {4,7,8,9,3,1,4,1};
// int[] array3 = { 7, 8, 9, 5, 4, 5, 6, 7, };
// var array4 = new int[8] {7,8,8,4,4,5,4,7};

// bool[] b = new bool[8];
// string[] s = new string[8];


// array[0] = 456;
// array[1] = 46;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * i;
//     Console.Write(array[i] + " ");
// }

// System.Threading.Thread.Sleep(10000);
// Console.Clear();


int[] createArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


int[] arr = createArray(8);
PrintArray(arr);