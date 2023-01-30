/* Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
​Например, задан массив:
​1 4 7 2
​5 9 2 3
​8 4 2 4
​1 7 -> такого числа в массиве нет
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

void FindCoord(int[,] matrix)
{
    Console.Write("Введите строку ячейки: ");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите столбец ячейки: ");
    int column = Convert.ToInt32(Console.ReadLine());

    int currentRow = matrix.GetLength(0);
    int currentColumn = matrix.GetLength(1);
    
    if (row > currentRow || column > currentColumn) 
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else 
    {
        Console.WriteLine(matrix[row-1, column-1]);
    }
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

const int ROWS = 4;
const int COLUMNS = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] resultMatrix = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(resultMatrix);
Console.WriteLine();
FindCoord(resultMatrix);
