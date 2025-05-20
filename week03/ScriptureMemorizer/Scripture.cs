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

    public void HideRandomWords(int numToHide, List<Word> words)
    {
        int count = 0;
        while(numToHide > count)
            {
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(1, words.Count);
            if(words[index]._isHiden == false){
            words[index]._isHiden = true;
            count++;
            }
            }
    }

}