using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Represents a journal containing multiple entries.
/// </summary>
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    /// <summary>
    /// Adds a new entry to the journal.
    /// </summary>
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    /// <summary>
    /// Displays all entries in the journal.
    /// </summary>
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    /// <summary>
    /// Saves all journal entries to a file.
    /// </summary>
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine(entry.ToCsvFormat());
            }
        }
    }

    /// <summary>
    /// Loads journal entries from a file, replacing current entries.
    /// </summary>
    public void LoadFromFile(string fileName)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }
    }
}
