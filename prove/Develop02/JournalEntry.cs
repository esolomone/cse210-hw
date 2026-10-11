class JournalEntry
{
    public string _date; //attributes
    public string _prompt;
    public string _response;

    

    public void DisplayJournalEntry()
    {
        Console.Write($"{_date}, {_prompt}"); // displays contents on screen
        Console.WriteLine(_response);
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "How was your day. ",
            "Talk about someone you met.",
            "Talk about a significant event in your day",
            "What were you grateful for today?"

        };
        _date = DateTime.Now.ToString(); 
        _prompt = prompts[0];
        Console.Write($"{_prompt}");
        _response = Console.ReadLine();
    }
}