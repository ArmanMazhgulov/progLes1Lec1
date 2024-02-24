// Задайте массив.Напишите программу,которая определяет,присутствует ли заданное число в массиве.
// Программа должна выдать ответ: Да/Нет.
// Примеры:
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

using System.Collections;

// int[] array = new int[8];
// int[] array1 = new int[8]{4,6,8,9,3,9,4,4};
// int[] array3 = new int[]{4,6,8,9,3,9,4,4};

Console.WriteLine("Введите число для поиска");
int targetNum = Convert.ToInt32(Console.ReadLine());
int[] array = { 5, 6, 9, 2, 2, 9, 3, 1, 0 };
bool res = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]== targetNum)
    {
        res=true;
        break;
    }
    
}

Console.WriteLine(res ? "Да" : "Нет");

// или
// string result = res ? "Да" : "Нет";
// Console.WriteLine(result);
