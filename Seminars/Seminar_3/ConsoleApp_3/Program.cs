// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.


Console.Write("Введите занчение Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите занчение Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите занчение Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите занчение Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2)); //Math.Sqrt - корень из числа, Math.Pow((x2-x1), 2) - квадрат разницы
Console.WriteLine($"Расстояние между двумя точками = {Math.Round(result, 2)}"); //Math.Round(result, 2) - округдение до сотых