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

/*
int max;

Console.WriteLine("Program for find max number between three numbers");

Console.Write("Input the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("input the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    if(a > c)
    {
        max = a;
    }
    else
    {
        max = c;
    }
}
else    
{
    if(b > c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
}

Console.Write("The max number is " + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("The program for find an even number");

Console.Write("Input your number: ");
int n = Convert.ToInt32(Console.ReadLine());

if((n % 2) == 0)
{
    Console.WriteLine("Your number " + n + " is even");
}
else
{
    Console.WriteLine("Your number is not even");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("The program for show all even nubers between 1 and N");
Console.Write("Input any number: ");

int n = Convert.ToInt32(Console.ReadLine());
int current = 2;

Console.Write("Even numbers are: ");

while(current < n)
{
    if((current % 2) == 0)
    {
        Console.Write(current + " ");
        current = current + 1;            
    } 
    else
    {
        current = current + 1;
    }
}