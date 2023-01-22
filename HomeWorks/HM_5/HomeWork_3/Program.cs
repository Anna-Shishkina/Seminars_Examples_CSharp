/* Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int [] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

int[] massive = GetRandomArray(4, -100, 100);
Console.WriteLine(string.Join(", ", massive));

int sum = 0;
for(int i = 0; i < massive.Length; i++)
{
   if (i % 2 == 1)
   {
    sum = sum + massive[i];
   }

}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
