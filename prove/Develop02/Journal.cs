class Journal
{
public List<JournalEntry> _entries;

public void DisplayJournal()
{
    foreach(JournalEntry entry in _entries)
    {
        entry.DisplayJournalEntry();
    }
}

public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);

    }
}