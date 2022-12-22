//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//1, -7, 567, 89, 223-> 3 - ошибка в проверочном примере №2.

//желательно без массива.



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
//
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//уравнения прямой линии
//понять как найти точку пересечения зная коэффициенты

//доп сложность
//исключения если прямые параллельны.
//две прямые погут совпадать

void FindTochka(int b1, int k1, int b2, int k2)
{
    if(k1 != k2)
    {
        int x = (b2 - b1)/(k1 - k2);
        int y = k2 * x + b1;
        Console.WriteLine($"точка пересечения на кооодинатах: {x} ; {y} .") 
    }           
    else Console.WriteLine("Прямые параллельны одна другой");    
}


Console.Write("Введите число b1")
bb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1")
kk1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2")
bb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2")
kk2 = Convert.ToInt32(Console.ReadLine());

FindTochka(bb1, kk1, bb2, kk2);

