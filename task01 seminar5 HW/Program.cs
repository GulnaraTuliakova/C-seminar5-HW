﻿// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine($"Чтобы найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, введите координаты.");
Console.WriteLine("Введите число b1:");
int b1 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите число k1:");
int k1 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите число b2:");
int b2 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите число k2:");
int k2 = int.Parse(Console.ReadLine()?? "0");
double x;
double y;
x = (b2-b1)/(k1-k2);
y = k1*x+b1;
Console.WriteLine($"Точка пересечения двух функций ({x},{y})");
