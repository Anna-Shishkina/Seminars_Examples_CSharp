/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Numbers(int num)
{
    int count = 1;
    while (num/10 !=0)
    {
        count ++;
    num = num / 10;
    }
return count;
}

int number = ReadNumber("Введите число: ");
int countOfNumbers = Numbers(number);
Console.WriteLine (countOfNumbers);