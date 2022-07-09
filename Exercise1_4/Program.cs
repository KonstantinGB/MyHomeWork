/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введиче число что бы узнать все четные числа от 1 до вашего");

int num;

Console.Write("Input integer number > 1: ");
num = Convert.ToInt32(Console.ReadLine());

int current = 2;

if(num > 1)
{
    while(current <= num)
    {
        Console.Write(current + " ");
        current = current + (2);
    }
}
else
    Console.Write("Вы ввели число равное 1 или меньше");
