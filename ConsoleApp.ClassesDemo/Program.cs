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
            Phone myPhone = new Phone("Iphone", "15 Pro", true);
            myPhone.ringTone("Can we talk");

            // Create an instance of the Song class
            Song mySong = new Song("Can we be lovers", "Teddy Pendagrass", 240);
            mySong.duration = 180; //Even with constructor, we can still modify properties
            mySong.play();

            // Create an instance of the Apartment class
            Apartment room9 = new Apartment(9,2,3);
            room9.displayInfo();

            // Create an instance of the Bible class
            Bible success = new Bible("Proverbs",16,3,4);
            success.text = "Commit your works to the Lord and your plans will be established. " +
                "The Lord works out everything to its proper end— even the wicked for a day of disaster";
            success.displayVerse();
        }
    }
    
}
