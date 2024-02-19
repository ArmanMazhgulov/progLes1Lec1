// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
bool result = num%7==0 && num%23==0;

if (result)
{
    Console.WriteLine($"{num} является кратным одновременно 7 и 23");
}
else
{
    Console.WriteLine($"{num} НЕ является кратным одновременно 7 и 23");
}

