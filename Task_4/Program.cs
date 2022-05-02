// Ввод число N
// Вывод показать промежутки от -N до N
Console.WriteLine("Введите целое число");
int N = int.Parse(Console.ReadLine());
int Y = -N;
while(Y <= N)
{
    Console.WriteLine(Y);
    Y++;
}