using System;

class Program
{    
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        if (grade > 69)
        {
            Console.WriteLine($"Your grade is a {letter}.");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass the class.");
        }

    }
}