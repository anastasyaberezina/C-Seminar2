﻿//Выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

int number = new Random().Next(10, 100);
int num1 = number / 10;
int num2 = number % 10;
int max = num1;

if (max<num2)
{
    max=num2;
}
Console.WriteLine($"Максимальная цифра числа {number} = {max}");