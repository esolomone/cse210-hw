class Journal
{
public List<Entry> _entries;

public void DisplayJournal()
{
    foreach(Entry entry in _entries)
    {
        entry.Display();
    }
}

public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);

    }
}