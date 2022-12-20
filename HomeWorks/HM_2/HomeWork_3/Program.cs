// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Понедельник");
}

if (number == 2)
{
    Console.WriteLine("Вторник"); 
}

if (number == 3)
{
    Console.WriteLine("Среда"); 
}

if (number == 4)
{
    Console.WriteLine("Четверг"); 
}

if (number == 5)
{
    Console.WriteLine("Пятница"); 
}

if (number == 6)
{
    Console.WriteLine("Суббота"); 
    Console.WriteLine("Выходной");
}

if (number == 7)
{
    Console.WriteLine("Воскресенье");
    Console.WriteLine("Выходной"); 
}

if ((number<1) || (number>7))
{
    Console.WriteLine("Вы ввели не верное число");
}