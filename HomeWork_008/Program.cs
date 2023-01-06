//54 задача Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.


/*
Console.WriteLine("This program orders the elements of each row of a two-dimensional array.");

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
Console.WriteLine("This is oridginal array:");
Show2dArray(myArray);

int[,] sortArray = SortRows(myArray);
Console.WriteLine("This is sorted array:");
Show2dArray(sortArray);
*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

/*
Console.WriteLine("This program to search for a string with a minimum sum of elements.");

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
Console.WriteLine();
Show2dArray(myArray);

int result = FindMinSumRow(myArray);
Console.WriteLine($"The first string with minimal sum of elements is - {result} string.");
*/


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
Console.WriteLine("This program to search the product of two arrays.");

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

int[,] ProductMatrix(int[,] arrA, int[,] arrB)
{
    int aRows = arrA.GetLength(0);
    int aColumns = arrA.GetLength(1);
    int bRows = arrB.GetLength(0);
    int bColumns = arrB.GetLength(1);
    int [,] result = new int[aRows, bColumns];
    if(aColumns != bRows)
        Console.WriteLine("arrays are not suitable for operation.");
    else
    {   
        for (int i = 0; i < aRows; i++)
            for (int j = 0; j < bColumns; j++)
                for (int k = 0; k < aColumns; k++)
                    result[i,j] = result[i,j] + arrA[i,k] * arrB[k,j];
    }
return result;    
}

int[,] arrayA = CreateRandom2dArray();
int[,] arrayB = CreateRandom2dArray();
Console.WriteLine("The first array:");
Show2dArray(arrayA);
Console.WriteLine("The second array:");
Show2dArray(arrayB);

Console.WriteLine("The product of two arrays is:");
int[,] result = ProductMatrix(arrayA, arrayB);
Show2dArray(result);
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
Console.WriteLine("This program for show 3D array with unique two-digit elements.");

int[, ,] CreateRandom3dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of pages: ");
    int pages = Convert.ToInt32(Console.ReadLine());
    int [, ,] array = new int[pages, rows, columns];
    
    return array;
}

void CorrectArray(int [,,] array)
{
    int[] tempArray = new int [array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int n;
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(10,100);
        n = tempArray[i];
        if(i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while(tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(10,100);
                    j = 0;
                    n = tempArray[i];
                }
                n = tempArray[i];
            }
        }
    }

    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
        for (int y = 0; y < array.GetLength(1); y++)
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x,y,z] = tempArray[count];
                count++;
            }
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {     
                Console.Write(array[i,j,k] + ($" ({i}, {j}, {k})") + "\t");
            }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] myArray = CreateRandom3dArray();

CorrectArray(myArray);
Show3dArray(myArray);
*/


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
Console.WriteLine("This program fills the array 4*4 with a spiral.");

int[,] CreateRandom2dArray()
{
    int rows = 4; 
    int columns = 4; 
    
    int [,] array = new int[rows, columns];
    int count = 0;
    for (int j = 0, i = 0; j < columns; j++)
        { 
            array[i,j] = count + 1;
            count += 1;
        }
    for (int i = 1, j = columns - 1; i < rows; i++)
        {
            array[i,j] = count + 1;
            count += 1;
        }
    for (int i = rows - 1, j = columns - 2; j >= 0; j--)
        {
            array[i,j] = count + 1;
            count += 1;
        }
    for (int i = rows - 2, j = 0; i > 0; i--)
        {
            array[i,j] = count + 1;
            count += 1;
        }
    for (int i = 1, j = 1; j < columns - 1; j++)
        {
            array[i,j] = count + 1;
            count += 1;
        }
    for (int i = 2, j = 2; j > 0; j--)
        {
            array[i,j] = count + 1;
            count += 1;
        }
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

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/