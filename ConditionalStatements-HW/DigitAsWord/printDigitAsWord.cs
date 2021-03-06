﻿//Problem 8. Digit as Word

//    Write a program that asks for a digit (0-9), and depending on the input, 
//    shows the digit as a word (in English).
//        Print “not a digit” in case of invalid input.
//        Use a switch statement.


using System;

class printDigitAsWord
{
    static void Main()
    {
        Console.Write("Please enter a number between 0 and 9: ");
        string input = Console.ReadLine();
        int number;

        bool isParsed = int.TryParse(input, out number);

        if (!isParsed)
        {
            Console.WriteLine("Not a digit!");
        }
        else
        {
            switch (number)
            {
                case 0: Console.WriteLine("Zero");
                    break;
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3: Console.WriteLine("Three");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                case 6: Console.WriteLine("Six");
                    break;
                case 7: Console.WriteLine("Seven");
                    break;
                case 8: Console.WriteLine("Eight");
                    break;
                case 9: Console.WriteLine("Nine");
                    break;
                default: Console.WriteLine("Not a digit!");
                    break;
            }
        }



    }
}

