// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int startNumber = 0 - number;

while (startNumber != number +1)
{
    Console.Write(startNumber);
    startNumber++;
}