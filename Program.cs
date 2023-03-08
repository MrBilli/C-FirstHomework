/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Input two numbers");

int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.WriteLine($"{num1} > {num2} - первое число больше");
}
else if(num1==num2)
{
    Console.WriteLine($"{num1} = {num2} - числа равны");
}
else
{
    Console.WriteLine($"{num2} > {num1} - второе число больше");
}