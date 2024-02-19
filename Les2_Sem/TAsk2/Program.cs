// Напишите программу, которая принимает на вход трёхзначное число 
// и возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2097152
// 254 => 5^4 = 625
// 617 => 1

Console.WriteLine("Введите трехзначное целое число");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999 || num >= -999 && num <= -100) // проерка на трехзначность
{
    int secondDigit = num / 10 % 10; // 256/100=25.6 %10 =>5
    int thirdDigit = num % 10; // 256 % 10 = 250 +6 => 6

    if (thirdDigit < 0)
    {
        thirdDigit = thirdDigit * -1;
    }

    int result = 1;
    int count = 1;
    while (count <= thirdDigit)
    {
        result *= secondDigit;
        count++;
    }
    Console.WriteLine($"{num} => {result}");
}
else
{
    Console.WriteLine("Некорректное число");
}