//Задача № 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Program for find max number between two numbers");

Console.Write("Input the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write("The max number is " + a);
}
else
{
    Console.Write("The max number is " + b);
}
*/

//Задача № 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Program for find max number between three numbers");

int max;

Console.Write("Input the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
max = a;

Console.Write("Input the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("input the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if(b > max)
{
    Console.Write("The max number is " + max);
}
if(c > max)
{
    Console.Write("The max number is " + c);
}
else
{
    Console.Write("The max number is " + a);
}
