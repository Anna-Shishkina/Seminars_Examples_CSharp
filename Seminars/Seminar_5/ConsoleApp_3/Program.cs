/*Задача 33: 
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
Массивы к задачам 32 и 33 можно сделать рандомными. 
В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет". */

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int [] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

int[] massive = GetRandomArray(12, -9, 9);
Console.WriteLine(string.Join(", ", massive));

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < massive.Length; i++)
{
   if (massive[i] == N)
   {
    Console.WriteLine("Да");
    break;
   }
   else if (i == massive.Length -1) // проверка на последний элемент массива, 
                                    // если не прописать, то выведется на экран ответ да или нет по каждому элементу массива
   {
    Console.WriteLine("Нет");
   }
}