using System;

/// <summary>
/// Represents a single journal entry.
/// </summary>
public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    /// <summary>
    /// Displays the journal entry in a readable format.
    /// </summary>
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("------------------------------");
    }

    /// <summary>
    /// Converts the journal entry to a CSV format.
    /// </summary>
    public string ToCsvFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}
