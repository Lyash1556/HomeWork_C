//болванки
/*
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

*/







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

/*
Console.WriteLine("this program looks for the value of an element at a specific position.");

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
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
//вернуть 1 мерный массив.


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


int[] FindAverage(int[,] array)
{
    int average = 0;
    int[] arr = new int[6]; 
    
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                average = average + array[i, j];
                arr[i] = average;                
            }
        }
    return arr;
}


int [,] myArray = CreateRandom2dArray();

Show2dArray(myArray);

FindAverage(myArray);
