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
}

public void CreateEntry()
{
    Entry newEntry = new Entry();
    newEntry.CreateEntry();
    _entries.Add(newEntry);
}
public void ReadFile()
{
    string filename = "Journal.txt";

    string[] lines = System.IO.File.ReadAllLines(filename);
    foreach (string line in lines)
    {
        string[] parts = line.Split('|');
        {
            Entry loadedEntry = new Entry();
            loadedEntry._date = parts[0];
            loadedEntry._prompt = parts[1];
            loadedEntry._response = parts[2];
            bool duplicateEntry = _entries.Any(entry => entry._date == parts[0]);
            if (!duplicateEntry)
                {
                _entries.Add(loadedEntry); 
                _entries = _entries.OrderBy(entry => entry._date).ToList();  //or             
                }

        }
    } 
    Console.WriteLine("Journal entries added from file!");
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
    
    Console.WriteLine("Journal entries saved!");
}
}