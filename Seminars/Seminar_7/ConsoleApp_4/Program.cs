/* Задача 51: 
Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
​Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольной
*/

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)     // Создаем матрицу
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

int GetSumDiag(int[,] matrix)
{
    int sumDiag = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)  // чтобы не выйти за границы, если матрица прямугольная
    {
        sumDiag += matrix[i, i];
    }
    return sumDiag;
}

const int ROWS = 4;
const int COLUMNS = 3;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);
Console.WriteLine();
int sum = GetSumDiag(array);
Console.WriteLine($"Сумма элементов главной диагонали: {sum}");