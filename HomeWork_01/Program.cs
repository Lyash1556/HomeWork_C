//Задача № 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Program for find max number between two numbers");

Console.Write("input a first number: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("input a second number: ");

int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write("The max number is " + a);
}
else
{
    Console.Write("The max number is " + b);
}