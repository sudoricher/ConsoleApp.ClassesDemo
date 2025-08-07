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

        // Not all properties need to be place in the constructor
        public Bible(string bookName, int chapter, int verseStart, int verseEnd)
        {
            this.bookName = bookName;
            this.chapter = chapter;
            this.verseStart = verseStart;
            this.verseEnd = verseEnd;
        }
        public void displayVerse()
        {
            Console.WriteLine($"{bookName} {chapter}:{verseStart}-{verseEnd} - {text}");
        }
    }
    
}
