﻿/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Например:
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Напишите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
int b= int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Максимально число: ");
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Максимально число: ");
    Console.WriteLine(b);
}