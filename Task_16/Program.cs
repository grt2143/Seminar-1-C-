﻿// Принимаем на вход 2 числа и проверяем является ли одно число квадратом другого?
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.WriteLine("Введите число 1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = int.Parse(Console.ReadLine());

if (number1 * number1 == number2 || number2 * number2 == number1)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");