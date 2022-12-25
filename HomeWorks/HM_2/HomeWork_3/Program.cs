// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number>=1) & (number<=5))
{
    Console.WriteLine("Рабочий день");
}

else if (number==6)
{
    Console.WriteLine("Выходной день");
}

else if (number==7)
{
    Console.WriteLine("Выходной день");
}

else
{
    Console.WriteLine("Вы ввели не верное число");
}