﻿
/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/


Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine());
int num1=number/10;
int num2=num1%10;
Console.WriteLine($"Из числа {number} получилось {num2}");
