using System;

namespace ConsoleApp.ClassesDemo
{
    public class Song 
    {   public string title;
        public string artist;
        public int duration; // in seconds
        
        public Song(string title, string artist, int duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
        }
        public void play()
        {
            Console.WriteLine($"Playing {title} by {artist}: {duration} seconds long");
        }
    }
    
}
