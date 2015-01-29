//Problem 5. The Biggest of 3 Numbers

//    Write a program that finds the biggest of three numbers.


using System;

class numberComparison
{
    static void Main()
    {
        Console.Write("Please enter a number a: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Please enter a number b: ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Please enter a number c: ");
        double numberC = double.Parse(Console.ReadLine());

        if (numberA > numberB && numberA > numberC)
        {
            Console.WriteLine("The biggest number is: " + numberA);
        }
        else if (numberA < numberC && numberB < numberC)
        {
            Console.WriteLine("The biggest number is: " + numberC);
        }
        else if (numberA < numberB && numberB > numberC)
        {
            Console.WriteLine("The biggest number is: " + numberB);
        }
    }
}

