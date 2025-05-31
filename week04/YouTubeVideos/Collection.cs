using System;

class Collection
{
    public List<Video> _videos = new List<Video>();


    public void Display(){
        Console.Clear();
        foreach (Video v in _videos){
            v.Display();
        }
    }
}