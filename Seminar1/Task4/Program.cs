// Задача 8 (Task4): Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int chet = 2;
while (num >= chet)
{
    Console.Write(chet + " ");
    chet = chet + 2;
}