using System;

public class Word
{
    private string _text;
    public bool _isHiden;
    
    public Word(string text)
    {
        _text = text;
        _isHiden = false;
    }


    public override string ToString()
    {
        return _isHiden ? "____" : _text;
    }

}