// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. Младший разряд 
// числа должен располагаться на 0- м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

Console.WriteLine("Введите натуральное трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int [3];
int i = 0;

int numCheck = num;
if (num < 0)
{
    Console.Write("Введено отрицательное число");
}

if (numCheck >= 100 && numCheck <= 999)
{
while (num>0)
{
    array[i]= num%10;
    i= i+1;
    num=num/10;
}
for (int j = 0; j < array.Length; j++)
{
   Console.Write($"{array[j]} "); 
}
}
