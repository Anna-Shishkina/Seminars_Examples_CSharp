/* Задача 44: 
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int[] Febonacci (int size)
{
    int[] Arr = new int[size];
    Arr[0] = 0;
    Arr[1] = 1;

    for(int i = 2; i < size; i++)
    {
        Arr[i] = Arr[i - 1] + Arr[i - 2];
    }
    return Arr;
}

int[] massive = Febonacci(7);
Console.WriteLine(string.Join(", ", massive));