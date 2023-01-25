/* Задача 39: 
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int [] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

void Reverse(int[] sourceArray)
{
    for(int i = 0; i < sourceArray.Length / 2; i++)
    {
        int temp = sourceArray[i];
        sourceArray[i] = sourceArray[sourceArray.Length - i -1];
        sourceArray[sourceArray.Length -i -1] = temp;
    }
}

const int size = 5;
const int leftRange = -9;
const int rightRange = 9;

int[] massive = GetRandomArray(size, leftRange, rightRange);
Console.WriteLine(string.Join(", ", massive));
Reverse(massive);
Console.WriteLine(string.Join(", ", massive));