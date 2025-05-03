using System;
public class Entry
{
    public string _question;
    public string _date;
    public string _answer;
    public void Display()
    {
        {
            Console.WriteLine($"Date: {this._date} - Prompt: {this._question} \n{this._answer}");
        }
    }
}