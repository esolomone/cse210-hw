using System;
using System.IO; 

public class Program
{
    static void Main(string[] args)
    {

        string userInput = "";
        Journal journal1 = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        
        while (userInput != "5")
        {
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            if (userInput=="1")
            {
                journal1.CreateEntry();
            }
            if(userInput == "2")
            {
                journal1.DisplayJournal();
            }
            if(userInput == "3")
            {
                journal1.ReadFile();
            }
            if(userInput == "4")
            {
                journal1.SaveFile();
            }
            }




    }
}