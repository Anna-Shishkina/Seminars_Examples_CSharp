/* Задача 57: 
Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
В нашей исходной матрице встречаются элементы от 0 до 9 */

/*
Первый вариант:
//                        строки     столбцы
int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
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

void Count(int[,] matrix)
{
    for(int temp = 0; temp <= 9; temp++)
    {
        int count = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                {
                    if(matrix[i, j] == temp)
                    {
                        count += 1;
                    }
                }
            }
        }
        Console.WriteLine($"{temp} встречается {count} раз.");
    }
}

const int ROWS = 3;
const int COLUMNS = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);
Console.WriteLine();
Count(array);
*/

// Второй вариант:
void Count(int[,] matrix)
{
    int[] counters = new int[10];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            int index = matrix[i, j];
            counters[index]++;
        }
    }
    for(int i = 0; i < counters.Length; i++)
    {
        Console.WriteLine($"Элемент {i}встречается {counters[i]} раз");
    }
}