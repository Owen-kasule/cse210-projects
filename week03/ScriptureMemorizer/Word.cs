class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetHint()
    {
        return _isHidden ? _text[0] + new string('_', _text.Length - 1) : _text;
    }
}
