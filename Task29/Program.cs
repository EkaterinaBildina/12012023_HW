// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите значения для заполениня массива");
Console.WriteLine("========================================");
Console.Write("Длина массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Min значение диапазона чисел массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Max значение диапазона чисел массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

CreateArray(array, minValue, maxValue);
PrintArray(array);

int[] CreateArray(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[" + arr[i] + ", ");
        else if (i == arr.Length - 1) Console.Write(arr[i] + "]");
        else Console.Write(arr[i] + ", ");
    }
}



