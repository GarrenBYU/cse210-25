using System;

public class Comment
{
    public string _name; 
    public string _text; 

        public Comment(string name, string text)
        {
            _text = text;
            _name = name;
        }

    public void Display()
    {
        Console.WriteLine($"{_text} \n-{_name} ");
    }
}