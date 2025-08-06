using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Person class
            Person thabo = new Person();
            thabo.name = "Thabo";
            thabo.age = 30;
            thabo.introduce();

            // Create an instance of the Phone class
            Phone myPhone = new Phone();
            myPhone.brand = "Iphone"; 
            myPhone.model = "Galaxy S21";
            myPhone.isSmartphone = true; 
            myPhone.ringTone();

            // Create an instance of the Song class
            Song mySong = new Song();
            mySong.title = "Can we be lovers";
            mySong.artist = "Teddy Pendagrass";
            mySong.duration = 240; //4minutes

            // Create an instance of the Apartment class
            Apartment room9 = new Apartment();
            room9.unitNumber = 9;
            room9.floor = 2;
            room9.numberOfRooms = 3;
            room9.displayInfo();

            // Create an instance of the Bible class
            Bible success = new Bible();
            success.bookName = "Proverbs";
            success.chapter = 16;
            success.verseStart = 3;
            success.verseEnd = 4;
            success.text = "Commit your works to the Lord and your plans will be established. " +
                "The Lord works out everything to its proper end— even the wicked for a day of disaster";
            success.displayVerse();
        }
    }
    
}
