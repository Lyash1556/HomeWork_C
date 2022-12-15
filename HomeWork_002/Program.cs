//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


/*
Console.WriteLine("The program for find the second number in a three-digit number.");

int SecondNum(int number)
{
    int secNum = (number / 10) % 10;
    return secNum;
}

Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SecondNum(num);

Console.WriteLine("The second number in your three-digit number is: " + result);
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


/*
Console.WriteLine("The program for find the third number in a given number.");

int ThirdNum(int number)
{
    while(number > 1000)
        {
            number = number / 10;
        }     
        int thirdNum = number % 10;
      
        return thirdNum;
}   

Console.Write("input an any number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99)
{
    int result = ThirdNum(num);
    Console.WriteLine(result);
}
else Console.WriteLine("Attention! The third number is not in your number.");
*/


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


/*
Console.WriteLine("The program for find the weekend days.");

bool FindDay(int n)
{
    if(n == 6 || n == 7) return true;
    else return false;
}

Console.Write("Input tne day of week number: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7)
{
    Console.WriteLine("It is not correct number!");
}
else
{
    bool result = FindDay(day);
    Console.WriteLine(result);
}
*/