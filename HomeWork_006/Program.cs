//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//1, -7, 567, 89, 223-> 3 - ошибка в проверочном примере №2.


/*
Console.WriteLine("You are using the program for find the amount of positive numbers.");

int FindAmount(int num)
{
    int amount = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Inpun {i} number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        if(x > 0) amount++;
    }
return amount;    
}

Console.Write("Input an amount of numbers for find positive numbers: ");
int m = Convert.ToInt32(Console.ReadLine());

int result  = FindAmount(m);
Console.Write($"The amount of positive numbers is {result}.");
*/



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
Console.WriteLine("You are using the program for finding the point of intersection of straight lines by equations y = k1 * x + b1, y = k2 * x + b2.");

void FindTochka(double b1, double k1, double b2, double k2)
{
    if(k1 != k2)
    {
        double x = (b2 - b1)/(k1 - k2);
        double y = ((b2 * k1) - (b1 * k2))/(k1 - k2);
        Console.WriteLine($"The points of intersection of lines on coordinates: {x} ; {y} .");
    }           
    else Console.WriteLine("The straight lines are parallel");    
}

Console.Write("input number b1: ");
double bb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input number k1: ");
double kk1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input number b2: ");
double bb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input number k2: ");
double kk2 = Convert.ToInt32(Console.ReadLine());

FindTochka(bb1, kk1, bb2, kk2);
*/