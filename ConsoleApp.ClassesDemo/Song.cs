using System;

namespace ConsoleApp.ClassesDemo
{
    public class Song 
    {   public string title;
        public string artist;
        public int duration; // in seconds
        public void play()
        {
            Console.WriteLine($"Playing {title} by {artist}");
        }
    }
    
}
