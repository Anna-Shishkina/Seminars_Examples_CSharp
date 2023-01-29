/* Задача 47.
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
​m = 3, n = 4.
​0,5 7 -2 -0,2
​1 -3,3 8 -9,9
​8 7,8 -7,1 9
*/

double[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)     // Создаем матрицу
// матрица двухмерная GetRandomMatrix (строки, столбцы, левая граница случайного диапозона, правая )
{
    double[,] matrix = new double[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)          // перебирает значения в строках
    {
        for(int j = 0; j < matrix.GetLength(1); j++)      // перебирает значения в столбцах
        {
            double a = leftRange + new Random().NextDouble() * (rightRange - leftRange);
            matrix[i, j] = Math.Round(a, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)                                                    // Выводим матрицу
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
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

double[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);

// Console.Writeline($"{a:f2}");  округление до двух знаков после запятой