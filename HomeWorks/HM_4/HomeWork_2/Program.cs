/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int ReadNumber(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();             
    int number = Convert.ToInt32(input);
    return number;                                      // Или можно записать как: return Convert.ToInt32(Console.ReadLine());
}

int Sum(int a)
{
    int result = 0;
    while(a != 0)
    {
        result += a % 10;
        a = a / 10;
    }
    return result;
}

int number = ReadNumber("Введите число: ");
if (number < 0)
{
    number *= -1;
}

int res = Sum(number);
Console.WriteLine($"Сумма цифр числа {number} = {res}");