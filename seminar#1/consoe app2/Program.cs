// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее

Console.Write("Enter number #1 ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number #2 ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
  Console.WriteLine ($"the biggest is {number1}");  
}
else
{
    Console.WriteLine ($"the biggest is {number2}");
}

