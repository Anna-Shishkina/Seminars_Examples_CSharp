// Задача 24
// Напишите программу, которая принимает на вход число (А) 
// и выдает сумму чисел от 1 до А.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());   // позволяет вытащить значение из метода и положить его во вне, например в "a"
}

int Sum1ToA(int a)
{
    int sum = 0;
    for(int i = 1; i <= a; i++)
    {
        sum += i;                                 // sum = sum +i;
    }
    return sum;
}

int number = ReadNumber("Введите число: ");
if(number > 0)
{
    int summa = Sum1ToA(number);
    Console.WriteLine(summa);
}

else Console.WriteLine("Введено не верное число.");