/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Строки и циклы в решении использовать нельзя!)

645 -> 6

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

int num1=(number%1000)/100;
if (number>99||number<= -99)
Console.WriteLine($"Из числа {number} получилось {num1}");
else {
 Console.WriteLine("В введенном числе третья цифра отсутствует");   
}

