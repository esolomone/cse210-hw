public class Entry
{
    public string _date; //attributes
    public string _prompt;
    public string _response;

    

    public void DisplayEntry()
    {
        Console.Write($"{_date}, {_prompt}"); // displays contents on screen
        Console.WriteLine(_response);
    }

    public void CreateEntry()
    {
        Random randomNumber = new Random();
        string[] prompts =
        {
            "\u001b[3mHow was your day? \u001b[0m", // added italics to distinguish response from prompt
            "\u001b[3mTalk about someone you met. \u001b[0m",
            "\u001b[3mTalk about a significant event in your day \u001b[0m",
            "\u001b[3mWhat were you grateful for today? \u001b[0m",
            "\u001b[3mDid you do anything nice for someone else today? \u001b[0m",
            "\u001b[3mHow were you blessed today? \u001b[0m"

        };
        _date = DateTime.Now.ToString(); 
        _prompt = prompts[randomNumber.Next(0, prompts.Length)];
        Console.Write($"{_prompt}");
        _response = Console.ReadLine();
    }
}