﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = Sum(number);
Console.WriteLine($"сумма цифр в числе: {number} = {sum}");

int Sum(int num)
{
    int sum = 0;

    while (num > 0)
    {
        int i = num % 10;
        sum = sum + i;
        num = num/10;
    }
    return sum;
}