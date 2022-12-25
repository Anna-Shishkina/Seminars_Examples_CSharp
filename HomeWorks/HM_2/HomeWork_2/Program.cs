// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new Random().Next(-20000,20000); //добавила этот период, чтобы можно проверить отрицательные числа
string numText = Convert.ToString(number);

if (numText.Length > 2 && number > 0)
{
  Console.WriteLine(number);
  Console.WriteLine(numText[2]);
}

else if (numText.Length > 2 && number < -99)
{
  Console.WriteLine(number);
  Console.WriteLine(numText[3]);
}

else 
{
  Console.WriteLine(number);
  Console.WriteLine("Третьей цифры нет");
}