// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите трехзначное: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write(number % 10);