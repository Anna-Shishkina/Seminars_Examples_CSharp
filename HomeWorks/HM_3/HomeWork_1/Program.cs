// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string numText = Console.ReadLine();

if (numText.Length ==5)
{
    if (numText[0] == numText[4] && numText[1] == numText[3])
    {
    Console.WriteLine($"Число {numText} является палиндромом");
    }

    else 
    {
    Console.WriteLine($"Число {numText} не является палиндромом");
    }
}

else 
{
    Console.WriteLine($"Число {numText} не пятизначное");
}