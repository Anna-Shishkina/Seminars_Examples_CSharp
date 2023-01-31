/* Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int NumbersRec(int M, int N)  
{
	if(N == M) return N;
    else return N + NumbersRec(M, N-1);
}
Console.WriteLine(NumbersRec(4, 8));