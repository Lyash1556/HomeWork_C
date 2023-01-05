//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
Console.WriteLine("This program displays numbers from N to 1 with recursion.");

void ShowNums(int num)
{
    if(num > 0) 
    {
        Console.Write(num + " ");
        ShowNums(num - 1);
    }
}
Console.Write("input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(n);
*/



//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
Console.WriteLine("This program find sum numbers from M to N with recursion.");

int FindSum(int m, int n)
{
    if(m < n)
        return FindSum(m + 1, n) + m;
    
    return n;
}

Console.Write("input a number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindSum(m,n));
*/


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
Console.WriteLine("This program calculates the Ackermann function.");
int Akkerman(int n, int m)
{
    if(n == 0)
        return m + 1;
    if(n != 0 && m == 0)
        return Akkerman(n - 1, 1);
    else return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.Write("input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number M: ");
int m = Convert.ToInt32(Console.ReadLine());

int result = Akkerman(n, m);

Console.WriteLine(result);
*/