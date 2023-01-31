/* Задача 60. 
...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0) 
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[, ,] GetRandomMatrix(int rows, int columns, int z, int leftRange, int rightRange)     
{
    int[, ,] matrix = new int[rows, columns, z];

    for(int i = 0; i < matrix.GetLength(0); i++)          
    {
        for(int j = 0; j < matrix.GetLength(1); j++)      
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(leftRange, rightRange +1) + i + j + k;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[, ,] matrix)                                                    
{
    for(int i = 0; i < matrix.GetLength(0); i++)          
    {
        for(int j = 0; j < matrix.GetLength(1); j++)      
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + ($"({i},{j},{k}) "));
            }  
        }
        Console.WriteLine();
    }
}

const int ROWS = 2;
const int COLUMNS = 2;
const int Z = 2;
const int LEFT_RANGE = 10;
const int RIGHT_RANGE = 100;

int[, ,] array = GetRandomMatrix(ROWS, COLUMNS, Z, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);
Console.WriteLine();