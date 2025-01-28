using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor to initialize the Scripture with a reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        SetWords(text);
    }

    // Method to set words by splitting the input text and creating Word objects
    private void SetWords(string text)
    {
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Method to get the full scripture text with reference and hidden words
    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return scriptureText.Trim();
    }

    // Method to hide a specified number of random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int randomIndex = random.Next(_words.Count);
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }

    // Method to check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
