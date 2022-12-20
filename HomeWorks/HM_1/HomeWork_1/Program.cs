// Напишите программу, которая на вход принимает два числа 
// и выдает, какое число большее, а какое меньшее.

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"Большее число = {number1}, меньшее число = {number2}");
}
else
{
    Console.WriteLine($"Большее число = {number2}, меньшее число = {number1}");
}