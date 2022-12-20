// Напишите программу, которая принимает на вход три числа 
// и выдает максимальное из этих чисел.

Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if((a == c) & (a == b) & (b == c))
Console.WriteLine("Все числа равны");

if((a == b) & (b != c))
Console.WriteLine($"Вы ввели одинаковые числа {a} = {b}");

if((b == c) & (c != a))
Console.WriteLine($"Вы ввели одинаковые числа {b} = {c}");

if((a == c) & (a != b))
Console.WriteLine($"Вы ввели одинаковые числа {a} = {c}");

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);