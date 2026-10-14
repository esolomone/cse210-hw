using System;

class Program
{
    static void Main(string[] args)


    {    
        int userInput;
        int sum = 0;
        int min = 0;
        int max = 0;

        List<int> numbers = new List<int>();
        do
        {
        Console.WriteLine("Enter a list of numbers, type '0' when finished.");
        Console.Write("Enter a number: ");
        userInput = int.Parse(Console.ReadLine());
        if(userInput != 0)
        numbers.Add(userInput);
        }
        while(userInput != 0);

        foreach (int number in numbers)
        {
            sum += number;
        }
        numbers.Sort();
        min = numbers[0];
        max = numbers[numbers.Count - 1];
        float average = (float)sum/numbers.Count;
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The highest number is {max}");
        Console.WriteLine($"The lowest number is {min}");

    }
}