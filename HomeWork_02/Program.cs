//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.WriteLine("Program for find the second number in a three-digit number");

int SecondNum(int number)
{
    int secnum = (number / 10) % 10;
    return secnum;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SecondNum(num);

Console.WriteLine("The second number in your number is " + result);
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("The program for find the third number in a given number");


int ThirdNum(int number)
{
    while(number > 1000)
        {
            number = number / 10;
        }     
        int findNum = number % 10;
      
        return findNum;
}   

Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99)
{
    int result = ThirdNum(num);
    Console.WriteLine(result);
}
else Console.WriteLine("Attention! The third nuber is not in your number");


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.



