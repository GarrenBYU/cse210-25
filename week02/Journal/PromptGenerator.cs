using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Prompt
{
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int initialNumber = randomGenerator.Next(1, _prompts.Count);
        string _firstPrompt = _prompts[initialNumber];
        return _firstPrompt;
    }
}