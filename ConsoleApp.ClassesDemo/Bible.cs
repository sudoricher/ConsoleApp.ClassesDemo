using System;

namespace ConsoleApp.ClassesDemo
{
    class Bible
    {
        public string bookName;
        public int chapter;
        public int verseStart;
        public int verseEnd;
        public string text;
        public void displayVerse()
        {
            Console.WriteLine($"{bookName} {chapter}:{verseStart}-{verseEnd} - {text}");
        }
    }
    
}
