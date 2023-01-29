/* Задача 48: 
Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int[,] GetRandomMatrix(int rows, int columns)     
{
    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)          // перебирает значения в строках
    {
        for(int j = 0; j < matrix.GetLength(1); j++)      // перебирает значения в столбцах
        {
            matrix[i, j] = i + j;
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

int[,] array = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(array);