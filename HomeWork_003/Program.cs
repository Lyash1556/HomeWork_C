//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
    

bool Palindrome(int number)
{
    int temporary = number;
    int value;
    int numberRev = 0;

    
    while(temporary > 0)
    {
        value = temporary % 10;
        numberRev = numberRev * 10 + value;
        temporary = temporary / 10;
    }
    if(numberRev == number) return true;
    else return false;    
}

Console.Write("Input an any number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Palindrome(num));
*/


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
Console.WriteLine("The program for find the distance between 2 points with known coordinates.");

double Segment(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double d = Math.Round((Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2))), 2);
        
    return d;
}

Console.WriteLine("Intput the coordinates point A:");
Console.Write("On axis X: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("On axis Y: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("On axis Z: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Intput the coordinates point B:");
Console.Write("On axis X: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("On axis Y: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("On axis Z: ");
double zB = Convert.ToDouble(Console.ReadLine());

double result = Segment(xA, yA, zA, xB, yB, zB);

Console.Write("The distance between 2 points is " + result);
*/



// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
Console.WriteLine("The program for find the cube of numbers between 1 and N.");

void FindCube(int n)
{
    int result = 1;
    
    while(result <= n)
    {
        Console.Write(Math.Pow(result, 3) + "  ");
        result++;
    }
}

Console.Write("Input the number N:  ");
int x = Convert.ToInt32(Console.ReadLine());

FindCube(x);
*/