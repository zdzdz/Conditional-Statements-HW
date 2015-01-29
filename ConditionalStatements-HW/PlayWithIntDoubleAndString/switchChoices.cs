//Problem 9. Play with Int, Double and String

//    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//        If the variable is int or double, the program increases it by one.
//        If the variable is a string, the program appends * at the end.
//    Print the result at the console. Use switch statement.


using System;

class switchChoices
{
    static void Main()
    {
        Console.Write("Please enter a you choice (int --> 1; double --> 2; string --> 3): ");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);

        switch (number)
        {
            case 1: Console.Write("Please enter an integer: ");
                int choice1 = int.Parse(Console.ReadLine());
                Console.WriteLine(choice1 + 1);
                break;
            case 2: Console.Write("Please enter a double value: ");
                double choice2 = double.Parse(Console.ReadLine());
                Console.WriteLine(choice2 + 1);
                break;
            case 3: Console.Write("Please enter a string: ");
                string choice3 = Console.ReadLine();
                Console.WriteLine(choice3 + "*");
                break;
        }
    }
}

