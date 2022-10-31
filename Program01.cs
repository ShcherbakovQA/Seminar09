// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void Sequence(double number)
{
    if (number > 1)
    {
        Console.Write($"{number},");
        Sequence(number - 1);
    }
    else if (number == 1)
    {
        Console.Write(number);
        Console.WriteLine();
    }
    if (number <= 0)
    {
        Console.WriteLine($"Натуральных чисел от 1 до {number} не существует!");
    }
}

double GetNumber()
{
    Console.WriteLine("Введите число N");
    return Convert.ToDouble(Console.ReadLine());
}

Sequence(Math.Truncate(GetNumber()));

