﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите a число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b)
max = b;

System.Console.WriteLine(max);