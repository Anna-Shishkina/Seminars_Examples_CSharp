/* Задача 53: 
Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/


//                        строки     столбцы
/*int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows,columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
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

void Change(int[,] matrix)
{
    int temp = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0)-1, j];
        matrix[matrix.GetLength(0)-1, j] = temp;
    }
}

const int ROWS = 3;
const int COLUMNS = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);
Console.WriteLine();
Change(array);
PrintMatrix(array); */


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

void ChangePlacesOfFirstLastRows(int[,] matrix)
{
    int lastRowIndex = matrix.GetLength(0) - 1;
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        (matrix[0, j], matrix[lastRowIndex, j]) = (matrix[lastRowIndex, j], matrix[0, j]);     //Тип типов - Кортеж
    }
}

const int ROWS = 4;
const int COLUMNS = 7;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] resultMatrix = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(resultMatrix);
Console.WriteLine("========================");
ChangePlacesOfFirstLastRows(resultMatrix);
PrintMatrix(resultMatrix);