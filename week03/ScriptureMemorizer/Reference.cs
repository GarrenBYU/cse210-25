using System;

public class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;
    public string _verseText;

    public void DisplayText(){
        Console.Write($"{_book} {_chapter}:{_verse}-{_endVerse}: ");
    }

}