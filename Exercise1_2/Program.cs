/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Для нахождения максимального из трёх чисел введите их");

int num1, num2, num3;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max) max=num2;
if(num3 > max) max=num3;

Console.WriteLine("Наибольшее число " + max);




