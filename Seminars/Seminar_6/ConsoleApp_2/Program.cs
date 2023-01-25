/* Задача 40: 
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

bool Treangle(int x, int y, int z)
{
    if ((x + y > z) 
        && (x +z > y)
        && (z + y > x))
    {
        return true;
    }
    return false;
}

Console.WriteLine($"Такой треугольник существует: {Treangle(a, b, c)}");