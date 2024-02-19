// Напишите программу, которая принимает на вход координаты точки (X и Y), п
// ричём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

Console.WriteLine("Введите x");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>0 && num2>0)
{
    Console.WriteLine("Данная точка находится в 1-ой координатной четверти");
}
if (num1<0 && num2>0)
{
    Console.WriteLine("Данная точка находится в 2-ой координатной четверти");
}
if (num1<0 && num2<0)
{
    Console.WriteLine("Данная точка находится в 3-ей координатной четверти");
}
if (num1>0 && num2<0)
{
    Console.WriteLine("Данная точка находится в 4-ой координатной четверти");
}
