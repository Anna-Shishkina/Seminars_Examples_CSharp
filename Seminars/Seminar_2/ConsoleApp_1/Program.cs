// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

int number = new Random().Next(10,1000);
int a = number / 100;
int c = number % 10;
int ac = a*10 + c;

Console.WriteLine(number);
Console.Write(ac);