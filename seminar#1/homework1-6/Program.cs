﻿// Задача 6: Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка) 

Console.Write("Enter number #1 ");
int number1 = Convert.ToInt32(Console.ReadLine());

if ((number1 % 2) == 0)
{
  Console.WriteLine ($"Number chetnoe");
}

else
{
    Console.WriteLine ($"Number nechetnoe");
}