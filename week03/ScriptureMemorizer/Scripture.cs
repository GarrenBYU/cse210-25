using System;

public class Scripture
{
    public Reference _reference;
    public string _originalText;
    private List<Word> _words = new List<Word>();

    public List<Word> ConvertVerse(string text)
    {
        foreach(string wordText in text.Split(' '))
        {
            this._words.Add(new Word(wordText));
        }
        return this._words;
    }

    public void HideRandomWords(int numToHide, List<Word> words)
    {
        int count = 0;
        while(numToHide > count && this.IsCompletelyHidden() != true)
            {
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(0, words.Count);
            if(words[index]._isHiden == false){
            words[index]._isHiden = true;
            count++;
            }
            }
    }

    public bool IsCompletelyHidden()
    {
        int count = 0;
        foreach(Word wordHidden in this._words)
        {
            if(wordHidden._isHiden == true)
            {
                count++;
            }
        }
        if(count == this._words.Count)
        {
            return true;
        }
        else{
            return false;
        }
    }

    public void DisplayText(List<Word> words)
    {
        foreach (Word word in words)
            {
                Console.Write(word + " ");
            }
    }

}