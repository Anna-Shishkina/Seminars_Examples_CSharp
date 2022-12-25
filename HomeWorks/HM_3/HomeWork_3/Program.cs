// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int startNumber = 1;

while (startNumber <= n)
{
    Console.WriteLine(Math.Pow(startNumber, 3));
    startNumber++;
}