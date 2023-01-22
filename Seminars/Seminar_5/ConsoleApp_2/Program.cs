/* Задача 32: 
Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
Массивы к задачам 32 и 33 можно сделать рандомными.*/

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

for(int i = 0; i < massive.Length; i++)
{
   massive[i] = massive[i] * (-1);
}

Console.WriteLine(string.Join(", ", massive));