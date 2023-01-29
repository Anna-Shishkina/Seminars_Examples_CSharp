/* Задача 46: 
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)     // Создаем матрицу
// матрица двухмерная GetRandomMatrix (строки, столбцы, левая граница случайного диапозона, правая )
{
    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)          // перебирает значения в строках
    {
        for(int j = 0; j < matrix.GetLength(1); j++)      // перебирает значения в столбцах
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange +1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)                                                    // Выводим матрицу
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