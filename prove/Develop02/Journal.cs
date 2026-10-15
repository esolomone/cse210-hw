using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
public List<Entry> _entries = new List<Entry>();

public void DisplayJournal()
{
    foreach(Entry entry in _entries)
    {
        entry.DisplayEntry();
    }
    Console.Write("Press any key to continue"); //added for user friendliness
    Console.Read();
}

public void CreateEntry()
{
    Entry newEntry = new Entry();
    newEntry.CreateEntry();
    _entries.Add(newEntry);
}
public void ReadFile()
{
    try
    {
        string filename = "Journal.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            
                Entry loadedEntry = new Entry(); //instead of displaying the file, the following code adds it to the journal, and can be viewed with display
                loadedEntry._date = parts[0]; 
                loadedEntry._prompt = parts[1];
                loadedEntry._response = parts[2];
                bool duplicateEntry = _entries.Any(entry => entry._date == parts[0]);
                if (!duplicateEntry) // checks to see if entry is already present, and if  not it adds it to the list, so you can load from same file multiple times
                    {
                    _entries.Add(loadedEntry); 
                    _entries = _entries.OrderBy(entry => entry._date).ToList();  //after loading entries from file, it orders the entries list
                    Console.WriteLine($"{parts[0]} {parts[1]} {parts[2]}");             
                    }


        }
    }       
    catch (Exception error)
    {
        Console.WriteLine("No file in default location, save first."); // added to prevent crashing if nothing is in default location. 
    }
    Console.WriteLine("Journal entries added from file! Press any key to continue. ");
    Console.Read();
}



public void SaveFile()
{
    string filename = "Journal.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
        }
    }
    
    Console.WriteLine("Journal entries saved to file!");
}
}