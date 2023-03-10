/* Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double ReadNumber(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();             
    double number = Convert.ToInt32(input);
    return number;                                      // Или можно записать как: return Convert.ToInt32(Console.ReadLine());
}

double k1 = ReadNumber("Введите первое число k1: ");
double b1 = ReadNumber("Введите второе число b1: ");
double k2 = ReadNumber("Введите третье число k2: ");
double b2 = ReadNumber("Введите четвертое число b2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;

Console.WriteLine($"Две прямые пересекаются в точке: {x}; {y}");
