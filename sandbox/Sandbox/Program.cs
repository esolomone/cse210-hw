using System;

class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();
        myCircle._radius = 10;

        double area = myCircle._GetArea();

        Console.WriteLine(area);

    // static double AddNumbers(double x, int y)
    // {
    //     return x + y;
    // }
    // static string MyName()
    // {
    //     return "Bob";
    // }
    // static void DisplayGreeting(string name)
    // {
    //     Console.WriteLine($"Welcome {name}, it's nice to meet you");
    // }
    // static void Main(string[] args)
    // {
    //     string myName = MyName();
    //     DisplayGreeting(myName);
    //     double total = AddNumbers(12.234, 20);
    //     Console.WriteLine(total);
    //     bool done = false;
    //     while (! done)
    //     {
    //         Console.Write("Are we done (y/n)? ");
    //         done = Console.ReadLine() == "y";
    //     }

    //     static void Main(string[] args)
    // {
    //     bool done;
    //     do
    //     {
    //         Console.Write("Are we done (y/n)? ");
    //         done = Console.ReadLine().ToLower() == "y";
    //     } while (! done);
    // for(int i = 100000; i > -100000; i--)
    //     {
    //         Console.WriteLine(i);
    //     }

        // List<string> myFriends = new List<string> {"Bob", "Betty", "Bubba"};

        // foreach(string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }
    //     Console.WriteLine("Hello World!");
    //     Console.WriteLine("Hey Jude.");
    //     Console.WriteLine("Hey Je.");
    //     Console.WriteLine("awesome");
    // /*
    // multiline comment
    // */
    // // single line comment //

    // if (x==10)
    //     {
    //        // logic
        
    }
}


