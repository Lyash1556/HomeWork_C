//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*

Console.WriteLine("The program for find the amount even numbers of array.");

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
            array[i] = new Random().Next(minValue, maxValue - 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
            Console.Write(array[i]);
        else
            Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

int FindNumber(int[] array)
{
    int amount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
            {
                amount++;
            }
    }
    return amount;
}

Console.Write("Input namber elemets: ");
int m = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 1000;

int[] myArray = CreateRandomArray(m, min, max);

ShowArray(myArray);

int result = FindNumber(myArray);

Console.Write($"The amount even numbers of array is: {result}");

*/





//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.



/*
Console.WriteLine("The program for find the sum not even numbers of array.");

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
            array[i] = new Random().Next(minValue, maxValue - 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
            Console.Write(array[i]);
        else
            Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

int FindSumNumbers(int[] array)
{
    int i = 1;
    int sum = 0;
    while(i < array.Length)
    {
        sum = sum + array[i];
        i = i + 2;
    }
    return sum;
}

Console.Write("Input namber elemets: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min pussible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max pussible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, min, max);
ShowArray(myArray);

int result = FindSumNumbers(myArray);
Console.Write($"The sum not even numbers of array is: {result}");

*/



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.WriteLine("The program for find the difference between max Value and min value of array.");

double[] CreateUserArray(int size)
{
    double[] array = new double[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void ShowArray(double[] array)
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

double FindDifference(double[] array)
{
    double min = array[0];
    double max = array[0];

        for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            array[i] = max;
        if(array[i] < min)
            array[i] = min;
    }
    return max, min;
}

Console.Write("Input namber elemets: ");
int m = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateUserArray(m);

ShowArray(myArray);

double result = FindDifference(myArray);
Console.Write($"The difference between max and min elements array is: {result}");
