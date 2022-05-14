// Из случайного 3х значного числа удалить вторую цифру

int slNumber = new Random().Next(100, 1000);
Console.WriteLine($"Number = {slNumber}");
int finalNumber = FindNumber (slNumber);
Console.WriteLine($"Final Number = {finalNumber}");

int FindNumber (int num)
{
    int firstDigit = num / 100;
    //int secondDigit = (num / 10) % 10;
    int thirdDigit = num % 10;
    return ((num / 100) * 10 + num % 10);
}
