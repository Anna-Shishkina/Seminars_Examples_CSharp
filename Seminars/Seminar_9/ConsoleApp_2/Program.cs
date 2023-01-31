/* Задача 65: 
Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

int m = 6;
int n = 10;

void NumbersRec(int M, int N)         // рекурсией
{    
    if (N == M + 1) return;   
    else Console.Write($"Число {N}");
    NumbersRec (M, N +1); 
    
} 

Console.WriteLine(NumbersRec(m, n)); 


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
------------
int n = 10;
int m = 6;

void RecN (int N, int M) 

{
if (M == N + 1) return;

else Console.Write($"Число: {M}  "); RecN(N, M + 1);


}

RecN(n, m);