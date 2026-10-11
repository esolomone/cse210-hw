using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = Random.Shared.Next(1, 10); 
        int guess = -1;

        do
        {       
            Console.Write("What is the magic number? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
        } while (guess != magicNumber);


    }
}