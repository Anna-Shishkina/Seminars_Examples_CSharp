// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.

int first2 = 0;
int second2 = 0;

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
if(first<0) {first2 = first * (-1);}
else first2 = first;

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
if(second<0) {second2 = second * (-1);}
else second2 = second;

if(Math.Sqrt(first2) == second2)
{
    Console.WriteLine($"Число {first} является квадратом числа {second}");
}
else if(Math.Sqrt(second2) == first2)
{
    Console.WriteLine($"Число {second} является квадратом числа {first}");
}

else
{
    Console.WriteLine($"Числа {first} и {second} не является квадратом друг друга");
}