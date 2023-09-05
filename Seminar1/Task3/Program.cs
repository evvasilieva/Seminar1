// Задача 6 (Task3): Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
﻿Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int chet = num % 2;
if (chet == 0)
{
    Console.WriteLine("Число " + " " + num + " " + " четное?");
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Число " + " " + num + " " + " четное?");
    Console.WriteLine("Нет!");
}