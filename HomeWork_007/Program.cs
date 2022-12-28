//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.WriteLine("This program creates a two-dimensional array of random real numbers.");

double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double [,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = Math.Round((new Random().NextDouble() * 10), 1);
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
            Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет. 
/*
Console.WriteLine("This program looks for the value of an element at a specific position.");

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min passible value: ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max passible value: ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minvalue, maxvalue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
            Console.WriteLine();
    }
    Console.WriteLine();

}

void FindElement(int[,] array, int row, int column)
{   
    int element = 0;
    if(row <= array.GetLength(0) || column <= array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                if (i == row && j == column)
                {
                    element = array[i,j];
                    Console.WriteLine($"Your search element is: {element}");
                }
    }
    else Console.WriteLine("That Element not found!");
}

int [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.Write("Input elements row: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input elements column: ");
int b = Convert.ToInt32(Console.ReadLine());

FindElement(myArray, a, b);
*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.WriteLine("This program looks arithmetic mean of the elements in each column of a two-dimensional array.");

double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double [,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().NextDouble() * 10;
    Console.WriteLine();
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j],2) + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] FindAverage(double[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {   
        double sum = 0;
        double avg = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        avg = sum / array.GetLength(0);
        newArray[j] = Math.Round(avg, 1);
    }
    return newArray;
}

void ShowAvgArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write(array[i]);
        else    
            Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine("The array with arithmetic mean of the elements in each column is here: ");

ShowAvgArray(FindAverage(myArray));
Console.WriteLine();
*/