// перевести 10-чное число в двоичное

int number = 13;                    //число которое надо сконверт-ть в двоичное

PrintBinaryView(number);

void PrintBinaryView(int n)         // вызываем метод
{
    if(n <= 0) return;               
    PrintBinaryView(n / 2);         // вызов метода самого себя, рекурсия
    Console.Write(n % 2);
}

