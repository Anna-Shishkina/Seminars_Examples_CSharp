// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// не использовать Math.Pow() и аналоги!

int ReadNumber(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();             
    int number = Convert.ToInt32(input);
    return number;                                      // Или можно записать как: return Convert.ToInt32(Console.ReadLine());
}

int Power(int a, int b)
{
    int result = 1;
    for(int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}

int numberA = ReadNumber("Введит первое число: ");
int numberB = ReadNumber("Введите натуральное второе число: ");

if(numberB <= 0)
{
    Console.WriteLine("Введено не натуральное число");
}

else
{
    int res = Power(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} = {res}");
}