// 54 задача Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
}

int[,] SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1); k++)
                if(array[i,j] >= array[i,k])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
    return array;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

int[,] sortArray = SortRows(myArray);
Show2dArray(sortArray);



*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
}

int FindMinSumRow(int[,] array)
{   
    int sum = 0;
    int[] arrSum = new int [array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
            arrSum[i] = sum;
        }
    }   
    int min = arrSum[0]; 
    int iMin = 0;
    for (int k = 0; k < arrSum.Length; k++)
    {
        if(arrSum[k] < min)
        {
            min = arrSum[k];
            iMin = k+1;
        }
    }
    return iMin;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

int result = FindMinSumRow(myArray);
Console.WriteLine($"Первая строка с наименьшей суммой элементов - {result} строка");


*/


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

int[,] ProductArrays(int[,] arr1, int[,] arr2)
{
    int [,] array = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int x = 0; x < arr1.GetLength(0); x++)
    {        
        for (int y = 0; y < arr1.GetLength(0); y++)
        {
            for (int i = 0, l = 0; i < arr1.GetLength(0); i++, l++)
            {
                for (int j = 0, k = 0; j < arr1.GetLength(0); j++, k++)
                {
                    array[i,j] = arr1[i,j] * arr2[k,l];
                }
            }
        }
    }
}
    
int[,] array1 = CreateRandom2dArray();
Show2dArray(array1);
Console.WriteLine();

int[,] array2 = CreateRandom2dArray();
Show2dArray(array2);





//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)


*/




//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
