// Программа принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
