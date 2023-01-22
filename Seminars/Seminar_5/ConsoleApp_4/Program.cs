﻿/* Задача 37: 
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] array = {1,2,3,4,5};                                  // есть массив

int size = (array.Length + 1) / 2;                          // получаем длину нового массива, которая  д.б. пополам меньше чем исходная или +1 если длина массива не четная

int[] newArray = new int[size];                             // новый массив на новых size элементов
for (int i = 0; i < array.Length / 2; i++)                  // цикл умножения значений в симетриченых индексах
                                                            // пока индекс, начиная с нулевого, меньше длины половинчатого массива (середины массива), прибавляй индекс +1
{
    newArray[i] = array[i] * array[array.Length - 1 - i];   // массив = элемент * последний элемент -1 -i
                                                            // значение в нулевом индексе * на последнее, значение в первом индексе * на предпоследнее и тд
}

if(array.Length % 2 == 1)                                      // если элемент по середине
{
    newArray[size - 1] = array[array.Length / 2];              // середина старого массива - array[array.Length / 2] в конец нового newArray[size - 1]
}

Console.WriteLine(string.Join(", ", newArray));
