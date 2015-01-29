//Problem 2. Bonus Score

//    Write a program that applies bonus score to given score in the range [1…9] 
//    by the following rules:
//        If the score is between 1 and 3, the program multiplies it by 10.
//        If the score is between 4 and 6, the program multiplies it by 100.
//        If the score is between 7 and 9, the program multiplies it by 1000.
//        If the score is 0 or more than 9, the program prints “invalid score”.


using System;

class scoreResult
{
    static void Main()
    {
        Console.Write("Please enter a score: ");
        string input = Console.ReadLine();
        int score;
        int result = 0;

        if (!int.TryParse(input, out score))
        {
            Console.WriteLine("Invalid score!");
        }
        else if (score >= 1 && score<=3)
        {
            result = score * 10;
            Console.WriteLine("Your result is: " + result);
        }
        else if (score >= 4 && score <= 6)
        {
            result = score * 100;
            Console.WriteLine("Your result is: " + result);
        }
        else if (score >= 7 && score <= 9)
        {
            result = score * 1000;
            Console.WriteLine("Your result is: " + result);
        }
        else if (score <= 0 || score > 9)
        {
            Console.WriteLine("Invalid score!");
            
        }
    }
}

