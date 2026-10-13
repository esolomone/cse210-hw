using System;

class Program
{
    static void Main(string[] args)


    {    
        int userInput;
        int sum = 0;
        int average;
        int min = 0;
        int max = 0;

        List<int> numbers = new List<int>();
        do
        {
        Console.WriteLine("Enter a list of numbers, type '0' when finished.");
        Console.Write("Enter a number: ");
        userInput = int.Parse(Console.ReadLine());
        numbers.Add(userInput);

        }while(userInput != 0);
        foreach (int number in numbers)
        {
            if(number > max)
            {
                max = number;
            }
            else if(number < min)
            {
                min = number;
            }
            sum += number;
            average = sum/numbers.Count;

        }
    }
}