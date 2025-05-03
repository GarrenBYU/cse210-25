using System;
using System.ComponentModel;
using System.IO;
public class Journal
{
    public List<String> _entries = new List<String>();
    public void AddEntry(String entry)
    {
        
        this._entries.Add(entry);
        this._entries.Add(" ");
    }
    public void DisplayAll(){
        foreach(string entry in this._entries){
            Console.WriteLine(entry);
        }
    }
     public void SaveToFile(String file, String pass){
        string fileName = file;
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine(pass);

            foreach(string entry in this._entries)
            {
                outputFile.WriteLine(entry);
            }
        }
     }
    public void LoadFromFile(String file){
        string filename = file;
        string filename2 = file;
        string passwordInFile;
        try{
            using(StreamReader reader = new StreamReader(filename))
            {
                passwordInFile = reader.ReadLine();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("We were unable to open this file.");
            Console.WriteLine("e.Message");
            return;
        }
        Console.WriteLine("Enter the password: ");
        string passwordUserEntered = Console.ReadLine();

        if(passwordUserEntered == passwordInFile && passwordInFile.Contains("Date:") == false){
            Console.WriteLine("Access granted.");
            string[] lines = System.IO.File.ReadAllLines(filename2);

            for (int i = 0; i < lines.Length; i++)
            {
                //string[] parts = line.Split(",");
                this._entries.Add(lines[i]);
            }            
        }
        else if(passwordInFile.Contains("Date:") == true){
            string[] lines = System.IO.File.ReadAllLines(filename2);

            for (int i = 0; i < lines.Length; i++)
            {
                //string[] parts = line.Split(",");
                this._entries.Add(lines[i]);
            }  
        }
        else{
            Console.WriteLine("Access denied.");
        }
        // string[] lines = System.IO.File.ReadAllLines(filename2);

        // for (int i = 0; i < lines.Length; i++)
        // {
        //     //string[] parts = line.Split(",");
        //     this._entries.Add(lines[i]);
        // }
        //this._entries.Add('\n');
    } 
    // public void RecievePassword(String file){
    //     string filename = file;
    //     string passwordInFile;
    //     try{
    //         using(StreamReader reader = new StreamReader(filename))
    //         {
    //             passwordInFile = reader.ReadLine();
    //         }
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine("We were unable to open this file.");
    //         Console.WriteLine("e.Message");
    //         return;
    //     }
    //     Console.WriteLine("Enter the password: ");
    //     string passwordUserEntered = Console.ReadLine();

    //     if(passwordUserEntered == passwordInFile){
    //         Console.WriteLine("Access granted.");
    //         LoadFromFile(file);
    //     }
    //     else{
    //         Console.WriteLine("Access denied.");
    //     }
    // }
}