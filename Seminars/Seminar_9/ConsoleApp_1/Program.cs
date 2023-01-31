/* Задача 63: 
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

string NumbersRec(int a, int b)         // рекурсией
{    
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);    
    else return String.Empty; 
} 

Console.WriteLine(NumbersRec(1, 5)); 

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int n = 6;
void RecN (int number) 

{
if (number == 0) return;

else RecN(number - 1); Console.Write($"Число: {number}  ");


}

RecN(n);