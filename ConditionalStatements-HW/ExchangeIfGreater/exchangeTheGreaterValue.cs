//Problem 1. Exchange If Greater

//    Write an if-statement that takes two double variables a and b 
//    and exchanges their values if the first one is greater than the second one. 
//    As a result print the values a and b, separated by a space.


using System;

class exchangeTheGreaterValue
{
    static void Main()
    {
        Console.Write("Please enter a number a: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Please enter a number b: ");
        double numberB = double.Parse(Console.ReadLine());

        double tempvalue;

        if (numberA > numberB)
        {
            tempvalue = numberA;
            numberA = numberB;
            numberB = tempvalue;
        }

        Console.WriteLine("Print a and b (exchanged): {0}  {1}", numberA, numberB);
    }
}

