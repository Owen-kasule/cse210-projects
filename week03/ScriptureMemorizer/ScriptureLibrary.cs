using System.Collections.Generic;

class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that He gave His only begotten Son."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want.")
        };
    }

    public void DisplayScriptures()
    {
        for (int i = 0; i < _scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_scriptures[i].GetReference().GetDisplayText()}");
        }
    }

    public Scripture GetScripture(int choice)
    {
        return _scriptures[choice - 1];
    }
}
