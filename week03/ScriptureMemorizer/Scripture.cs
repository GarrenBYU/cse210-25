using System;

public class Scripture
{
    public Reference _reference;
    public string _originalText;

    public List<Word> ConvertVerse(string text)
    {
        List<Word> _words = new List<Word>();
        foreach(string wordText in text.Split(' '))
        {
            _words.Add(new Word(wordText));
        }
        return _words;
    }

}