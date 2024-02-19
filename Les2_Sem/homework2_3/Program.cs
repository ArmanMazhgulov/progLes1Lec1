// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Console.WriteLine("Введите целое число от 10 до 99");
int num = Convert.ToInt32(Console.ReadLine());

int firstDigit = num % 10;
int secondDigit = (num - firstDigit) / 10;

bool result = firstDigit > secondDigit;

if (result)
{
    Console.WriteLine($"{firstDigit}");
}
else
{
    Console.WriteLine($"{secondDigit}");
}