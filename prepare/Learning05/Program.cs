using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }
    static void PromptUserBirthYear(out int userBirthYear)
    {
        Console.Write($"Please enter the year you were born: ");
        userBirthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }
    static void DisplayResult(string name,int numberSquared,int userBirthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {numberSquared}");
        Console.WriteLine($"{name}, you will turn {2026-userBirthYear} this year.");    
    }

    static void Main(string[] args)
    {
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numberSquared = SquareNumber(number);
        PromptUserBirthYear(out int userBirthYear);
        DisplayResult(name, numberSquared, userBirthYear);




    }    
}               