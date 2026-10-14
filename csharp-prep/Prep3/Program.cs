using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNum = new Random();
        int magicNumber = randomNum.Next(1,100);
        int guess = -1;
        do
        {
        Console.Write("What is your magic number? ");
        string user_guess = Console.ReadLine();
        guess = int.Parse(user_guess);
        if(guess > magicNumber)
            {
                Console.Write("Lower, ");
            }
        else if(guess < magicNumber)
            {
                Console.Write("Higher, ");
            };

        
        }while(guess != magicNumber);





        Console.WriteLine("You guessed it!");
    }
}