// Напишите программу, которая на вход принимает целое число 
// и выдает его квадрат (число умноженное на само себя).

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;

Console.WriteLine($"Квадрат введенного числа = {result}");
