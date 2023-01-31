/* Задача 56: 
Задайте двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)     
{
    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)          
    {
        for(int j = 0; j < matrix.GetLength(1); j++)      
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange +1);
        }
    }
    return matrix;
}

void SumLines(int[,] array)
{
    int sum = 0;
    int min = 0;
    int row = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        
        if (sum < min || min == 0)
        {
            min = sum;
            row = i;
            sum = 0;
        }
    }
    Console.WriteLine($"{row+1} строка");
}

void PrintMatrix(int[,] matrix)                                                    
{
    for(int i = 0; i < matrix.GetLength(0); i++)          
    {
        for(int j = 0; j < matrix.GetLength(1); j++)      
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

const int ROWS = 3;
const int COLUMNS = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);
Console.WriteLine();
SumLines(array);