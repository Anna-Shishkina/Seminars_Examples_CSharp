// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

//Предполагаю, что в задаче опечатка - на вход координаты трех точек, тогда решение есть (иначе решения нет):

Console.Write("Введите значение Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)); //Math.Sqrt - корень из числа, Math.Pow((x2-x1), 2) - квадрат разницы
Console.WriteLine($"Расстояние между двумя точками = {Math.Round(result, 0)}"); //Math.Round(result, 0) - округдение до целого числа