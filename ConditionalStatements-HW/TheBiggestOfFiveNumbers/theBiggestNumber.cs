//Problem 6. The Biggest of Five Numbers

//    Write a program that finds the biggest of five numbers by using only five if statements.


using System;
using System.Threading;
using System.Globalization;

class theBiggestNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please enter a number a: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Please enter a number b: ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Please enter a number c: ");
        double numberC = double.Parse(Console.ReadLine());
        Console.Write("Please enter a number d: ");
        double numberD = double.Parse(Console.ReadLine());
        Console.Write("Please enter a number e: ");
        double numberE = double.Parse(Console.ReadLine());

        double biggest = numberA;

        if (biggest < numberB)
        {
            biggest = numberB;
        }
        else if (biggest < numberC)
        {
            biggest  = numberC;
        }
        else if (biggest < numberD)
        {
            biggest  = numberD;
        }
        else if (biggest < numberE)
        {
            biggest  = numberE;
        }
        
        Console.WriteLine("The biggest number is: " + biggest);
    }
}

