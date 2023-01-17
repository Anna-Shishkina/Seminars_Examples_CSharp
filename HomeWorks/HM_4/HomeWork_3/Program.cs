/* Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран. 
Данные вводятся с консоли пользователем  */

int[] FillArray()
{
    int[] arr = new int[8];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите число {i+1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int[] array = FillArray();
Console.WriteLine(string.Join(", ", array));