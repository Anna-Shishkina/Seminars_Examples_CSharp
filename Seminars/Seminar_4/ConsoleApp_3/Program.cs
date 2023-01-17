// Задача 28: 
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

/*int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetProdact(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
return result;
}

int number = ReadNumber("Введите число: ");
int prodact = GetProdact(number);
Console.WriteLine ($"Произведение чисел = {prodact}"); */

// решение факториалом:

Console.Write("Введите число: ");

string answer = Console.ReadLine();
int number = Convert.ToInt32(answer);

int factorial = 1;

if (number > 0)
{
    for (int i = 1; i <= number; i++)
    {
        factorial = factorial * i;
    }
Console.WriteLine(factorial);
}

else Console.WriteLine("Введите верное число");