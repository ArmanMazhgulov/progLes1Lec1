// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = num1 == num2 * num2;

if (result)
{
    Console.WriteLine($"a = {num1}, b = {num2} => {result}");
}
else 
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}