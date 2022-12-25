// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.


Console.Write("Введите трехзначное: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>99 && number<1000)
{
    int bc = number % 100;
    int b = bc / 10;
    Console.WriteLine(b);
}

else if (number<-99 && number>-1000)
{
    int num = number * -1;
    int bc = num % 100;
    int b = bc / 10;
    Console.WriteLine(b);
}

else
Console.WriteLine("Вы ввели не трехзначное число");