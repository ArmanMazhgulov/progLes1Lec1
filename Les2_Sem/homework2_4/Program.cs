// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int num = number;
int num2 = number;

while (num >= 10)
{
    num = num / 10;
    count = count * 10;
}

while (count >= 10)
{
    num2 = number / count;
    Console.Write($"{num2}, ");
    number = number - num2 * count;
    count = count / 10;
}

Console.Write($"{number}");