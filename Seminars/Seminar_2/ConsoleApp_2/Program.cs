// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b == 0)
{
    Console.WriteLine("Второе число не может быть 0");
}
else
{
    int rest = a % b;
    if (rest == 0)
    {
       Console.WriteLine("Кратно"); 
    }
    if (rest !=0)
    {
       Console.WriteLine($"Не кратно, {rest}");  
    }
}