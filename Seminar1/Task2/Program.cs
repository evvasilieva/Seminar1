// Задача 4 (Task 2): Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
﻿Console.WriteLine("Введите три числа, и узнайте, какое из них имеет максимальное значение.");
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());
int maxNum = 0;
if (num1 > maxNum) maxNum = num1;
if (num2 > maxNum) maxNum = num2;
if (num3 > maxNum) maxNum = num3;
Console.Write("Максимальное значение имеет число " + " " + maxNum);