﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int Promt (string text)
{
    Console.WriteLine (text);
    return Convert.ToInt32(Console.ReadLine());
}

int n = Promt("write n");

Console.WriteLine (PrintNumbers (n, 1));


string PrintNumbers (int start, int finish)
{
    if (start == finish)
    {
        return start.ToString();
    }
    return start + " " + PrintNumbers(start - 1, finish);

}