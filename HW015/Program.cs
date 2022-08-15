﻿
// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine($"Введите точку b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите точку k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите точку b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите точку k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

void Coordinat(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if ((k1 == k2) && (b1 == b2)) Console.WriteLine($"Прямые совпадают");
    else if (k1==k2) Console.WriteLine($"Прямые параллельны");
    else Console.WriteLine($"Координаты точки пересечения: ({x}; {y})");
}

Coordinat(b1, k1, b2, k2);
