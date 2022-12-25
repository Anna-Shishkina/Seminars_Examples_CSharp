// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

switch(number)
{
    case 1:
        Console.WriteLine($"Значения координат {number}й четверти: X>0 Y>0");
        break;

    case 2:
        Console.WriteLine($"Значения координат {number}й четверти: X<0 Y>0");
        break;
    
    case 3:
        Console.WriteLine($"Значения координат {number}й четверти: X<0 Y<0");
        break;

    case 4:
        Console.WriteLine($"Значения координат {number}й четверти: X>0 Y<0");
        break;
    
    default:
        Console.WriteLine("Такой четверти не существует");
        break;
}