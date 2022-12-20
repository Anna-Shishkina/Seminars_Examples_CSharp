// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if ((a == 1) & (b == 1))
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}

else if ((a == 0) & (b == 0))
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}

else if ((a == b))
{
    Console.WriteLine($"Число {a} не является квадратом числа {b}");
}

else if (a>b)
{
    if (a == b*b)
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}

else if (a<b)
{
    if (b == a*a)
    Console.WriteLine($"Число {b} является квадратом числа {a}");
}