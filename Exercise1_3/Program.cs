﻿/* 
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введиче число что бы узнать является ли число четным");

int num;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
