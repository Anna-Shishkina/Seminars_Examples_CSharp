/* Задача 58: 
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Другое решение:
6 16
9 6
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

int[,] MultiMatrix(int[,] array, int[,] array2)
{
    int[,] matrix = new int[array.GetLength(0), array.GetLength(1)];

    for(int i = 0; i < matrix.GetLength(0); i++)          
    {
        for(int j = 0; j < matrix.GetLength(1); j++)      
        {
            matrix[i, j] = array[i, j] * array2[i, j];
        }
    }
    return matrix;
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

const int ROWS = 2;
const int COLUMNS = 2;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);
Console.WriteLine();

int[,] array2 = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array2);
Console.WriteLine();

int[,] result = MultiMatrix(array, array2);
PrintMatrix(result);