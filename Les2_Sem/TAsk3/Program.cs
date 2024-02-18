//Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если второе число некратно первому, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());

int remainder = num1 % num2 ;

if (remainder == 0)
{
    //Console.Writeline("Первое число яляется кратным второму")
    Console.WriteLine($"{num1}, {num2} => ДА");
}
else
{
    Console.WriteLine($"{num1}, {num2} => НЕТ, {remainder}");
}