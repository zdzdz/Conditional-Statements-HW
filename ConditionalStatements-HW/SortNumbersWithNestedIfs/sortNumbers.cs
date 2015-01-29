//Problem 7. Sort 3 Numbers with Nested Ifs

//    Write a program that enters 3 real numbers and prints them sorted in descending order.
//        Use nested if statements.

//Note: Don’t use arrays and the built-in sorting functionality.

using System;

class sortNumbers
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
            if (numberB >= numberC)
            {
                Console.WriteLine("Descending order: " + " " + numberA + " " + numberB + " " + numberC);
            }
            else if (numberC >= numberB)
            {
                Console.WriteLine("Descending order: " + " " + numberA + " " + numberC + " " + numberB);
            }
            
        }
        else if (numberA < numberB && numberB > numberC)
        {
            if (numberA >= numberC)
            {
                Console.WriteLine("Descending order: " + numberB + " " + numberA + " " + numberC);
            }
            else if (numberC >= numberA)
            {
                Console.WriteLine("Descending order: " + numberB + " " + numberC + " " + numberA);
            }
        }
        else if (numberA < numberC && numberC > numberB)
        {
            if (numberA >= numberB)
            {
                Console.WriteLine("Descending order: " + numberC + " " + numberA + " " + numberB);
            }
            else if (numberB >= numberA)
            {
                Console.WriteLine("Descending order: " + numberC + " " + numberB + " " + numberA);
            }
        }
        else if (numberA == numberB && numberB == numberC)
        {
            Console.WriteLine("Descending order: " + numberA + " " + numberB + " " + numberC);
        }
    }
}

