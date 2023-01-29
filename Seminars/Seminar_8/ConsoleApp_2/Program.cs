/* Задача 55: 
Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
*/

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ChangePlacesRowsOnCols(int[,] matrix)
{   
    int oldRows = matrix.GetLength(0);
    int oldCols = matrix.GetLength(1);
    int[,] newMatrix = new int[oldCols, oldRows];

    for (int i = 0; i < oldCols; i++)
    {
        for (int j = 0; j < oldRows; j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }        
    }

    return newMatrix;
}

const int ROWS = 3;
const int COLUMNS = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] firstMatrix = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(firstMatrix);
Console.WriteLine("========================");
int[,] resultMatrix = ChangePlacesRowsOnCols(firstMatrix);
PrintMatrix(resultMatrix);