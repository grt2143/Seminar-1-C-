// Принимает на вход 2 числа
// Выводить является ли первое число кратным второму
// Если не кратно, то вывести остаток от деления

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

if (number1 % number2 == 0)
    Console.WriteLine("кратно");
else
    Console.WriteLine($"не кратно, остаток {number1 % number2}");
